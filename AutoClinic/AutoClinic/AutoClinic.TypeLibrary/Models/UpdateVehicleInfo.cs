using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClinic.TypeLibrary.Models
{
    public class UpdateVehicleInfo
    {
        public int VehicleID { get; set; }
        public string CustomerID { get; set; }
        public int? InsuranceID { get; set; }
        public string RegistrationNo { get; set; }
        public string SerialNo { get; set; }
        public int? ModelID { get; set; }
        public string Year { get; set; }
        public string EngineType { get; set; }
        public double? Milage { get; set; }
        public DateTime? PreviousServiceDate { get; set; }
    }
}
