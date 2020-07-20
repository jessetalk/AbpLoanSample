using LoanSample.Customer.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace LoanSample.Customer.EntityFramework.Migration
{
    [DependsOn(typeof(LoanSampleCustomerEntityFrameworkCoreModule))]

    public class CustomerEntityFrameWorkDbMigrationModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CustomerDbMigrationsContext>();
        }
    }
}
