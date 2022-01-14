using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClinic.TypeLibrary.Models
{
    public class AddCustomer
    {
        public string CustomerID { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string AddLine1 { get; set; }
        public string AddLine2 { get; set; }
        public int SuburbID { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public double AccountBalance { get; set; }
    }
}
