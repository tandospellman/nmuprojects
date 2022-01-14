using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClinic.TypeLibrary.ViewModels
{
    public class UspViewBookings
    {
        public string BookingID { get; set; }
        public string CustomerName { get; set; }
        public int QuoteID { get; set; }
        public string Brand { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Service { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public string Comment { get; set; }
        public bool Arrived { get; set; }
    }
}
