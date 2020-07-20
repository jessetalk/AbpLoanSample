using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LoanSample.Customer.EntityFramework.Migration
{
    public class CustomerDbContextMigrationFactory : IDesignTimeDbContextFactory<CustomerDbMigrationsContext>
    {
        public CustomerDbMigrationsContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<CustomerDbMigrationsContext>()
                .UseMySql(configuration.GetConnectionString("CustomerConnString"));

            return new CustomerDbMigrationsContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
