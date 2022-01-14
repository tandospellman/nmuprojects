using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace AutoClinicWeb
{
    public class Vehicle
    {
        DataAccessLayer dl = new DataAccessLayer();
        public int VehicleID { get; set; }
        public string CustomerID { get; set; }
        public string RegistrationNo { get; set; }
        public string SerialNo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string EngineType { get; set; }
        public double Milage { get; set; }
        public DateTime? PreviousServiceDate { get; set; }

        //Adds new vehicle
        public int AddCustomerVehicle(string customerID, string regNo, string make, string model, string year)
        {
            return dl.AddCustomerVehicle(customerID, regNo, make, model, year);
        }

        //Updates vehicle information
        public int UpdateVehicleInfo(string vehicleID,  string serialNo, string engineType, double milage, DateTime previousServiceDate)
        {
            return dl.UpdateVehicleInfo(vehicleID, serialNo, engineType, milage, previousServiceDate);
        }

        //Returns all vehicles
        public DataTable GetActiveVehicles()
        {
            return dl.GetActiveVehicles();
        }
    }
}