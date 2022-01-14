using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClinic.TypeLibrary.ViewModels
{
    public class UspViewVehicleInfo
    {
        public int VehicleID { get; set; }
        public string CustomerName { get; set; }
        public int InsuranceID { get; set; }
        public string RegistrationNo { get; set; }
        public string SerialNo { get; set; }
        public string Brand { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string EngineType { get; set; }
        public double Milage { get; set; }
        public string PreviousServiceDate { get; set; }
    }
}
