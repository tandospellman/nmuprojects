using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClinic.TypeLibrary.Models
{
    public class Booking
    {
        public string CustomerID { get; set; }
        public int? QuoteID { get; set; }
        public int VehicleID { get; set; }
        public int ServiceID { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public string Comment { get; set; }
        public bool Arrived { get; set; }
    }
}
