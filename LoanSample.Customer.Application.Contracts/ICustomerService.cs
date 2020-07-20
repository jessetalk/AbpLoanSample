using LoanSample.Customer.Application.Contracts.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace LoanSample.Customer.Application.Contracts
{
    public interface ICustomerService : IApplicationService
    {
        public Task<List<CustomerDto>> GetListAsync();

        public Task<CustomerDto> CreateAsync(CustomerDto customer);

        public Task<CustomerDto> AddLinkmanAsync(Guid customerId, LinkmanDto linkman);
    }
}
