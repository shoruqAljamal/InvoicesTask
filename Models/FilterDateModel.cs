using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Models
{
    public class FilterDateModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int StoreId { get; set; }
    }

}
