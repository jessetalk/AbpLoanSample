using LoanSample.Customer.Application.Contracts.Model;

namespace LoanSample.Customer.Domain.Profile
{
    public class CustomerProfile : AutoMapper.Profile
    {
        public CustomerProfile()
        {
            CreateMap<Domain.Entity.Customer, CustomerDto>().ReverseMap();
            CreateMap<Domain.Entity.Linkman, LinkmanDto>().ReverseMap();
        }
    }
}
