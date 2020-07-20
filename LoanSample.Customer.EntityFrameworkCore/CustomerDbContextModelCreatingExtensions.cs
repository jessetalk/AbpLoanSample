using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace LoanSample.Customer.EntityFrameworkCore
{
    public static class CustomerDbContextModelCreatingExtensions
    {
        public static void ConfigureCustomerStore(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Domain.Entity.Customer>(c =>
            {
                c.ToTable("Customer");
                c.ConfigureByConvention();
            });
        }
    }
}
