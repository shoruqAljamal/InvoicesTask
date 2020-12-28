using InvoicesTask.Entities;
using InvoicesTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.IRepos
{
   public interface IInvoiceRepo
    {

        Task<List<Invoice>> GetAllInvoices();
        Task<Invoice> GetInvoiceByID(int id);
        Task<Report> GetReport(FilterDateModel model);
        Task<Invoice> Add(Invoice invoice);
        Task<InvoiceItem> AddInvoiceItem(InvoiceItem invoice);
        Task<bool> Update(Invoice invoice);
        Task<bool> DeleteInvoiceItemByInvoiceID(int id);
        Task<bool> DeleteByID(int id);
    }
}
