using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;
using Volo.Abp.Identity;
using Volo.Abp.PermissionManagement;

namespace LoanSample.Customer.Domain
{
    [DependsOn(typeof(AbpIdentityDomainModule))]
    [DependsOn(typeof(AbpPermissionManagementDomainIdentityModule))]
    public class LoanSampleCustomerDomainModule: AbpModule
    {
    }
}
