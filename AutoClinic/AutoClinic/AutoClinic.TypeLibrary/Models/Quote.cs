using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClinic.TypeLibrary.Models
{
    public class Quote
    {
        public int BusinessID { get; set; }
        public DateTime QuoteDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double TotalCost { get; set; }
        public double Discount { get; set; }
        public bool Status { get; set; }
    }
}
