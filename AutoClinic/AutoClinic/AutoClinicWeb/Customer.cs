using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace AutoClinicWeb
{
    public class Customer
    {
        DataAccessLayer dl = new DataAccessLayer();
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PhoneNo { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public int? Active { get; set; }
        double AccountBalance { get; set; }

        //Adds new customer 
        public int AddCustomer(string firstName, string surname, string phoneNumber, string email)
        {
            return dl.AddCustomer(firstName, surname, phoneNumber, email);
        }
        
        //Adds new customer 
        public int AddCust(string firstName, string surname, string phoneNumber, string email)
        {
            return dl.AddCustomer(firstName, surname, phoneNumber, email);
        }

        //Returns all active customers
        public DataTable GetAllActiveCustomers()
        {
            return dl.GetAllActiveCustomers();
        }

        //Searches for a customer by their name
        public DataTable GetCustomerByName(string firstName, string surname)
        {
            return dl.GetCustomerByName(firstName, surname);
        }

        //Searches for a customer by their vehicle
        public DataTable GetCustomersByVehicle(string regNumber)
        {
            return dl.GetCustomerByVehicle(regNumber);
        }

        //Updates a customer
        public int UpdateCustomerInfo(string customerID, string firstName, string surname, DateTime dateOfBirth,
            string phoneNo, string email, string addLine1, string addLine2, string suburb, string city, string province, 
            string postalCode, int active, double accountBalance)
        {
            return dl.UpdateCustomerInfo(customerID, firstName, surname, dateOfBirth, phoneNo, email, addLine1, addLine2,
                suburb, city, province, postalCode, active, accountBalance);
        }

        //Returns a customer's info
        public DataTable GetCustomerInfo(string firstName, string surname)
        {
            return dl.GetCustomerInfo(firstName, surname);
        }
    }
}