using InvoicesTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Supervisors
{
    public interface ISupervisor
    {

        Task<List<CustomerModel>> GetAllCustomers();
        Task<List<InvoiceModel>> GetAllInvoices();
        Task<InvoiceModel> GetInvoiceByID(int id);
        Task<bool> UpdateInvoice(InvoiceModel invoiceModel);
        Task<InvoiceModel> AddInvoice(InvoiceModel invoiceModel);
        Task<List<ItemModel>> GetAllItems();
        Task<List<StoreModel>> GetAllStores();
        Task<Report> GetReport(FilterDateModel model);
    }
}
