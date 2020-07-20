using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Volo.Abp.Domain.Entities;

namespace LoanSample.Customer.Domain.Entity
{
    public class Customer: AggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }

        public string IdNo { get; set; }


        private List<Linkman> _linkman = new List<Linkman>();

        public ReadOnlyCollection<Linkman> Linkman {
            get {
                return _linkman.AsReadOnly();
            }
        }

        public void AddLinkman(Linkman linkman)
        {
            this._linkman.Add(linkman);
        }

    }
}
