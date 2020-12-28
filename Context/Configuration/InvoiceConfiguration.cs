using InvoicesTask.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Context.Configuration
{
    public class InvoiceConfiguration
    {
        public InvoiceConfiguration(EntityTypeBuilder<Invoice> entity)
        {
            entity.HasOne<Customer>(e=>e.Customer)
                  .WithMany(c=>c.Invoices)
                  .HasForeignKey(e=>e.CustomerId)
                  .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            entity.HasOne<Store>(e => e.Store)
                 .WithMany(c => c.Invoices)
                 .HasForeignKey(e => e.StoreId)
                 .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

    
        }
    }
}
