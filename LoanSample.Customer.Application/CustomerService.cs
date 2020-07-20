using LoanSample.Customer.Application.Contracts;
using LoanSample.Customer.Application.Contracts.Model;
using LoanSample.Customer.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace LoanSample.Customer.Application
{
    public class CustomerService : ApplicationService, ICustomerService
    {
        private readonly IRepository<Domain.Entity.Customer> _customerRepo;
        private readonly IUnitOfWorkManager _unitOfWork;

        public CustomerService(IRepository<Domain.Entity.Customer> customerRepo,IUnitOfWorkManager unitOfWork)
        {
            _customerRepo = customerRepo;
            _unitOfWork = unitOfWork;
        }

        public async Task<CustomerDto> AddLinkmanAsync(Guid customerId, LinkmanDto linkman)
        {
            var customer = await _customerRepo.GetAsync(c => c.Id == customerId);

            var linkmanEntity = ObjectMapper.Map<LinkmanDto, Domain.Entity.Linkman>(linkman);
            customer.AddLinkman(linkmanEntity);

            using (var uow = _unitOfWork.Begin())
            {
                var customerResult = await _customerRepo.UpdateAsync(customer, false);

                if (linkman.Name == "jesse")
                {
                    throw new System.InvalidOperationException("Duplicated name jesse");
                }

                await uow.CompleteAsync();
                return ObjectMapper.Map<Domain.Entity.Customer, CustomerDto>(customerResult);
            }
        }

        public async Task<CustomerDto> CreateAsync(CustomerDto customer)
        {
            var entity = ObjectMapper.Map<CustomerDto, Domain.Entity.Customer>(customer);
            var result = await _customerRepo.InsertAsync(entity);

            return ObjectMapper.Map<Domain.Entity.Customer, CustomerDto>(result);
        }

        public async Task<List<CustomerDto>> GetListAsync()
        {
            var customer = await _customerRepo.GetListAsync();
            return ObjectMapper.Map<List<Domain.Entity.Customer>, List<CustomerDto>>(customer);
        }
    }
}
