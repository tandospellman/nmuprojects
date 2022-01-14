using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AutoClinicWeb
{
    public class BookingClass
    {
        DataAccessLayer dl = new DataAccessLayer();
        public string BookingNumber { get; set; }
        public string CustomerName { get; set; }
        public int VehicleNumber { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Arrived { get; set; }
        public string CustomerID { get; set; }
        public int? QuoteID { get; set; }
        public int ServiceID { get; set; }
        public string Comment { get; set; }
        public bool Active { get; set; }

        // Returns all active bookings
        public DataTable GetAllBookings()
        {
            return dl.GetAllBookings();
        }

        // Adds a new booking
        public int CreateBooking(string CustomerID, int VehicleNumber, int ServiceID, DateTime BeginDate, string Comment, bool Arrived, bool Active)
        {
            return dl.CreateBooking(CustomerID, VehicleNumber, ServiceID, BeginDate, Comment, Arrived, Active);
        }

        //Updates a booking
        public int UpdateBooking(int BookingNumber, string CustomerID, int VehicleNumber, int ServiceID, DateTime BeginDate, DateTime EndDate, string Comment, bool Arrived, bool Active)
        {
            return dl.UpdateBooking(BookingNumber, CustomerID, VehicleNumber, ServiceID, BeginDate, EndDate, Comment, Arrived, Active);
        }

        //Returns bookings based on Customer
        public DataTable GetBookingCustomer(string CustomerID)
        {
            return dl.GetBookingCustomer(CustomerID);
        }

        //Returns bookings based on Vehicle
        public DataTable GetBookingVehicle(int VehicleNumber)
        {
            return dl.GetBookingVehicle(VehicleNumber);
        }

        //Returns name and vehicle of selected booking
        public DataTable GetSelectedBooking(int BookingNumber)
        {
            return dl.GetSelectedBooking(BookingNumber);
        }
    }
}
