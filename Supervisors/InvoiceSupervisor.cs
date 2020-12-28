using InvoicesTask.Entities;
using InvoicesTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Supervisors
{
    public partial class Supervisor
    {

        public async Task<List<InvoiceModel>> GetAllInvoices()
        {
            var invoices = await _IInvoiceRepo.GetAllInvoices();
            return _mapper.Map<List<InvoiceModel>>(invoices);
        }

        public async Task<InvoiceModel> GetInvoiceByID(int id)
        {
            var invoice = await _IInvoiceRepo.GetInvoiceByID(id);
            return _mapper.Map<InvoiceModel>(invoice);
        }
        public async Task<Report> GetReport(FilterDateModel model)
        {
            return await _IInvoiceRepo.GetReport(model);
        }

        public async Task<bool> UpdateInvoice(InvoiceModel invoiceModel)
        {

            var invoiceEntity = _mapper.Map<Invoice>(invoiceModel);
            await _IInvoiceRepo.DeleteInvoiceItemByInvoiceID(invoiceModel.ID);
            await _IInvoiceRepo.Update(invoiceEntity);
            foreach (var iteminvoice in invoiceEntity.InvoiceItems)
            {
                iteminvoice.Invoice = null;
                if(iteminvoice.ItemId != 0 && iteminvoice.Item != null)
                    iteminvoice.Item = null;
                await _IInvoiceRepo.AddInvoiceItem(iteminvoice);
            }
            return true;
        }

        public async Task<InvoiceModel> AddInvoice(InvoiceModel invoiceModel)
        {
            var invoiceEntity = _mapper.Map<Invoice>(invoiceModel);
            invoiceEntity.CreatedDate = DateTime.Now;
            invoiceEntity.IsPaid = false;
            return _mapper.Map<InvoiceModel>(await _IInvoiceRepo.Add(invoiceEntity));
        }

    }
}
