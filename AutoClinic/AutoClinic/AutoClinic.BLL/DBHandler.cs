using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoClinic.DAL;
using AutoClinic.TypeLibrary.Models;
using AutoClinic.TypeLibrary.ViewModels;
using AutoClinic.TypeLibrary.Interfaces;

namespace AutoClinic.BLL
{
    public class DBHandler
    {
        private readonly IAutoClinic dbaccess;
        public DBHandler(IAutoClinic db)
        {
          this.dbaccess = db;
        }

        public bool CreateQuote(Quote quote)
        {
            return dbaccess.CreateQuote(quote);
        }

        public bool BookAppointment(Booking booking)
        {
            return dbaccess.BookAppointment(booking);
        }

        public bool UpdateBooking(UpdateBooking booking)
        {
            return dbaccess.UpdateBooking(booking);
        }

        public bool AssignMechanic(AssignMechanic mechanic)
        {
            return dbaccess.AssignMechanic(mechanic);
        }

        public List<UspViewBookings> ViewBookings()
        {
            return dbaccess.ViewBooking();
        }

        public bool UpdateVehicle(UpdateVehicleInfo vehicle)
        {
            return dbaccess.UpdateVehicle(vehicle);
        }

        public List<UspViewSchedule> ViewSchedule(string mechanicID)
        {
            return dbaccess.ViewSchedule(mechanicID);
        }

        /*public List<UspViewVehicleInfo> ViewVehicleInfo(int vehicleID)
        {
            return dbaccess.ViewVehicleInfo(vehicleID);
        }*/

        public List<UspViewCustInfo> ViewCustInfos(string customerID)
        {
            return dbaccess.ViewCustInfo(customerID);
        }

        public bool AddCustomer(AddCustomer customer)
        {
            return dbaccess.AddCustomer(customer);
        }

        public List<UspCheckLogin> CheckLogin(string username)
        {
            return dbaccess.CheckLogin(username);
        }
    }
}
