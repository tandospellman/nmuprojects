using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoClinic.TypeLibrary.Models;
using AutoClinic.TypeLibrary.ViewModels;


namespace AutoClinic.TypeLibrary.Interfaces
{
    public interface IAutoClinic
    {
        bool CreateQuote(Quote quote);
        bool BookAppointment(Booking booking);
        bool UpdateBooking(UpdateBooking booking);
        bool AssignMechanic(AssignMechanic mechanic);
        List<UspViewBookings> ViewBooking();
        bool UpdateVehicle(UpdateVehicleInfo vehicle);
        List<UspViewSchedule> ViewSchedule(string mechanicID);
        UspViewVehicleInfo ViewVehicleInfo(int vehicleID);
        List<UspViewCustInfo> ViewCustInfo(string customerID);
        bool AddCustomer(AddCustomer customer);
        List<UspCheckLogin> CheckLogin(string username);
    }
}
