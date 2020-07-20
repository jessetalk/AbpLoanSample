using LoanSample.Customer.Domain;
using LoanSample.Customer.EntityFramework.Migration;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace LoanSample.Customer.Migrator
{
    [DependsOn(typeof(LoanSampleCustomerDomainModule),
        typeof(AbpAutofacModule),
        typeof(CustomerEntityFrameWorkDbMigrationModule)
        )]
    public class CustomerStoreDbMigratorModule: AbpModule
    {

    }
}
