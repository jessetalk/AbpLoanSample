using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace LoanSample.Customer.Domain.Entity
{
    public class Linkman: Entity<Guid>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string IdNo { get; set; }

    }
}
