using InvoicesTask.Context;
using InvoicesTask.Entities;
using InvoicesTask.IRepos;
using InvoicesTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Repos
{
    public class InvoiceRepo : IInvoiceRepo
    {
        private readonly InvoiceContext _InvoiceContext;

        public InvoiceRepo(InvoiceContext InvoiceContext)
        {
            _InvoiceContext = InvoiceContext;
        }


        public async Task<Invoice> Add(Invoice invoice)
        {
            _InvoiceContext.Add(invoice); //Change Tracker : only change the state 
            await _InvoiceContext.SaveChangesAsync();
            return invoice;
        }
        public async Task<InvoiceItem> AddInvoiceItem(InvoiceItem invoice)
        {
            _InvoiceContext.Add(invoice); //Change Tracker : only change the state 
            await _InvoiceContext.SaveChangesAsync();
            return invoice;
        }

        public async Task<bool> DeleteByID(int id)
        {
            var invoice = await GetInvoiceByID(id);
            _InvoiceContext.Remove(invoice); //Change Tracker : only change the state 
            var success = await _InvoiceContext.SaveChangesAsync();
            if (success == 0)
                return false;
            return true;
        }
        public async Task<bool> DeleteInvoiceItemByInvoiceID(int id)
        {
            var invoiceItems= await _InvoiceContext.InvoiceItems.Where(e => e.InvoiceId == id).ToListAsync();
            foreach(var item in invoiceItems)
            {
                _InvoiceContext.Remove(item);
            }
            await _InvoiceContext.SaveChangesAsync();
            return true;
          
        }


        public async Task<List<Invoice>> GetAllInvoices()
        {
            var invoices = await _InvoiceContext.Invoices.ToListAsync();
            return invoices;
        }

        public async Task<Invoice> GetInvoiceByID(int id)
        {
            var invoice = await _InvoiceContext.Invoices.Where(e => e.ID == id)
                                                .Include(e=>e.Customer)
                                                .Include(e =>e.Store)
                                                .Include(e => e.InvoiceItems)
                                                    .ThenInclude(e => e.Item)
                                                         .FirstOrDefaultAsync();
            return invoice;
        }

      public async Task<Report> GetReport(FilterDateModel model)
        {

            var invoices = await _InvoiceContext.Invoices
                .Where(e => e.StoreId == model.StoreId && e.CreatedDate > model.FromDate && e.CreatedDate < model.ToDate)
                                                                .Include(e => e.Store)

                                                              .Include(e => e.InvoiceItems)  
                                                             .ThenInclude(e => e.Item).ToListAsync();
           
            var invoiceCount = invoices.Count;
            Report report = invoices.Select(er => new Report()
                {
                    StoreName = er.Store.Name,
                    TotalPrices = er.InvoiceItems.Sum(e => e.Item.Price * e.Quantity),
                    InvoiceCount = invoiceCount,
                    ItemCounts = er.InvoiceItems.Sum(e => e.Quantity)
                }).FirstOrDefault();
            return  report;

        }
        public async Task<bool> Update(Invoice invoice)
        {
            _InvoiceContext.Update(invoice); //Change Tracker : only change the state 
            try
            {
                await _InvoiceContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }
            return true;
        }
    }
}
