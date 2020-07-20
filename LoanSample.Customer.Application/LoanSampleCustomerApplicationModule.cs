using LoanSample.Customer.Application.Contracts;
using LoanSample.Customer.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Identity;

namespace LoanSample.Customer.Application
{
    [DependsOn(typeof(LoanSampleCustomerApplicationContractsModule),
        typeof(LoanSampleCustomerDomainModule),
        typeof(AbpAutoMapperModule)
        )]
    [DependsOn(typeof(AbpIdentityApplicationModule))]
    public class LoanSampleCustomerApplicationModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<LoanSampleCustomerApplicationModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                //Add all mappings defined in the assembly of the MyModule class
                options.AddMaps<LoanSampleCustomerApplicationModule>();
            });
        }
    }
}
