using Volo.Abp.Modularity;
using Volo.Abp.Identity;

namespace LoanSample.Customer.Application.Contracts
{
    [DependsOn(typeof(AbpIdentityApplicationContractsModule))]
    public class LoanSampleCustomerApplicationContractsModule:AbpModule
    {
    }
}
