using InvoicesTask.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Context.Configuration
{
    public class InvoiceItemConfiguration
    {
        public InvoiceItemConfiguration(EntityTypeBuilder<InvoiceItem> entity)
        {
            entity.HasKey(vt => new { vt.InvoiceId, vt.ItemId });
            entity.HasOne(vt => vt.Invoice)
                   .WithMany(v => v.InvoiceItems)
                   .HasForeignKey(vt=>vt.InvoiceId)
                   .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);
            entity.HasOne(vt => vt.Item)
             .WithMany(t => t.InvoiceItems)
             .HasForeignKey(vt => vt.ItemId)
             .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

        }
    }
}
