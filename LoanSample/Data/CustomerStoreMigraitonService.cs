using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LoanSample.Customer.Domain.Data
{
    public class CustomerStoreMigraitonService: ITransientDependency 
    {
        public ILogger<CustomerStoreMigraitonService> Logger { get; set; }

        private readonly ICustomerStoreSchemaMigrator _dbSchemaMigrator;

        public CustomerStoreMigraitonService(ICustomerStoreSchemaMigrator dbSchemaMigrator)
        {
            _dbSchemaMigrator = dbSchemaMigrator;

            Logger = NullLogger<CustomerStoreMigraitonService>.Instance;
        }

        public async Task MigrateAsync()
        {
            Logger.LogInformation("Started database migrations...");

            Logger.LogInformation("Migrating database schema...");
            await _dbSchemaMigrator.MigrateAsync();

            Logger.LogInformation("Successfully completed database migrations.");
        }

    }
}
