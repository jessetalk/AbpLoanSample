using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace LoanSample.Customer.Domain.Data
{
    public interface ICustomerStoreSchemaMigrator
    {
        Task MigrateAsync();
    }
}
