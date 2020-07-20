using LoanSample.Customer.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LoanSample.Customer.EntityFramework.Migration
{

    [Dependency(ServiceLifetime.Transient, ReplaceServices = true)]
    [ExposeServices(typeof(ICustomerStoreSchemaMigrator))]
    public class EntityFrameworkCoreCustomerDbSchemaMigrator
       : ICustomerStoreSchemaMigrator
    {
        private readonly CustomerDbMigrationsContext _dbContext;

        public EntityFrameworkCoreCustomerDbSchemaMigrator(CustomerDbMigrationsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}
