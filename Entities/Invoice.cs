using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Entities
{
    public class Invoice : GeneralEntity
    {
        public DateTime CreatedDate { get; set; }
        public bool IsPaid { get; set; }
        public int StoreId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
    }
}
