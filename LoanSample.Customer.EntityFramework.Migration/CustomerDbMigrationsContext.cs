using LoanSample.Customer.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace LoanSample.Customer.EntityFramework.Migration
{
    [ConnectionStringName("CustomerConnString")]
    public class CustomerDbMigrationsContext : AbpDbContext<CustomerDbMigrationsContext>
    {
        public CustomerDbMigrationsContext(DbContextOptions<CustomerDbMigrationsContext> options)
         : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */
            builder.ConfigureCustomerStore();
        }
    }
}

