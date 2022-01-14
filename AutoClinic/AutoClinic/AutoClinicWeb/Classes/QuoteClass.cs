using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace AutoClinicWeb.Classes
{
    public class QuoteClass
    {
        DataAccessLayer dl = new DataAccessLayer();
        public int QuoteID { get; set; }
        public string BusinessName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ExpiryDate { get; set; }
        public float TotalCost { get; set; }
        public float Discount { get; set; }
        public bool Status { get; set; }
        public int BusinessID { get; set; }
        public bool Active { get; set; }
        public string CustomerID { get; set; }

        //Returns all Active Quotes
        public DataTable GetAllQuotes()
        {
            return dl.GetAllQuotes();
        }

        //Returns quote tied to customer
        public DataTable GetQuoteCustomer(string CustomerID)
        {
            return dl.GetQuoteCustomer(CustomerID);
        }

        //Creates a new QUote
        public int CreateQuote(DateTime DateCreated, DateTime ExpiryDate, float TotalCost, float Discount, bool Status)
        {
            return dl.CreateQuote(DateCreated, ExpiryDate, TotalCost, Discount, Status);
        }
    }
}