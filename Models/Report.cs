using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Models
{
    public class Report
    {
        public string StoreName { get; set; }
        public double TotalPrices { get; set; }
        public int InvoiceCount { get; set; }
        public int ItemCounts { get; set; }
    }
}
