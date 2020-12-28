using InvoicesTask.Context.Configuration;
using InvoicesTask.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Context
{
    public class InvoiceContext : DbContext
    {
        public InvoiceContext(DbContextOptions<InvoiceContext> options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Store> Stores { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           new CustomerConfiguration(modelBuilder.Entity<Customer>());
           new InvoiceConfiguration(modelBuilder.Entity<Invoice>());
           new InvoiceItemConfiguration(modelBuilder.Entity<InvoiceItem>());
           new ItemConfiguration(modelBuilder.Entity<Item>());
           new StoreConfiguration(modelBuilder.Entity<Store>());



        }

    }


}
