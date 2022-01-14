using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AutoClinicWeb
{
    public class Mechanic
    {
        DataAccessLayer dl = new DataAccessLayer();
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Note { get; set; }

        //Returns a list of all active mechanics
        public DataTable GetActiveMechanics()
        {
            return dl.GetActiveMechanics();
        }

        //Returns selected mechanic's info
        public DataTable GetMechanicInfo(string employeeNumber)
        {
            return dl.GetMechanicInfo(employeeNumber);
        }

        //Updates the selected mechanic's info
        public int UpdateMechanic(string employeeID, string phoneNo, string email, string addLine1,
            string addLine2, string suburb, string city, string postalCode)
        {
            return dl.UpdateMechanic(employeeID, phoneNo, email, addLine1, addLine2, suburb, city,
                postalCode);
        }

        //Returns mechanics name and ids
        public DataTable GetMechanicsIDs()
        {
            return dl.GetMechanicsIDs();
        }
    }
}