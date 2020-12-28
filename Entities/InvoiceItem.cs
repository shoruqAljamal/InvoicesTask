using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Entities
{
    public class InvoiceItem : GeneralEntity
    {
        public int InvoiceId { get; set; }
        public int ItemId { get; set; }
        public Item Item{ get; set; }
        public Invoice Invoice { get; set; }
        public int Quantity { get; set; }


    }
}
