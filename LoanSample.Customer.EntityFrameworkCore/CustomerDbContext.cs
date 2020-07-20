using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace LoanSample.Customer.EntityFrameworkCore
{
    [ConnectionStringName("CustomerConnString")]
    public class CustomerDbContext : AbpDbContext<CustomerDbContext>
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
          : base(options)
        {

        }

        public DbSet<Domain.Entity.Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureCustomerStore();
        }
    }
}
