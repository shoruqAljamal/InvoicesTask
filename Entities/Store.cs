using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Entities
{
    public class Store : GeneralEntity
    {
        public string Name { get; set; }
        public List<Invoice> Invoices { get; set; }

    }
}
