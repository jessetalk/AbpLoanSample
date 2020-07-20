using System;
using System.Collections.Generic;
using System.Text;

namespace LoanSample.Customer.Application.Contracts.Model
{
    public class CustomerDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }

        public string IdNo { get; set; }

        public List<LinkmanDto> Linkman { get;set; }
    }

    public class LinkmanDto 
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string IdNo { get; set; }

    }
}
