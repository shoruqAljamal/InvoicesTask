using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Models
{
    public class InvoiceModel
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsPaid { get; set; }
        public int StoreId { get; set; }
        public int CustomerId { get; set; }
        public CustomerModel Customer { get; set; }
        public StoreModel Store { get; set; }
        public List<InvoiceItemModel> InvoiceItems { get; set; }
    }
}
