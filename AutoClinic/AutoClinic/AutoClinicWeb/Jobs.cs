using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace AutoClinicWeb
{
    public class Jobs
    {
        DataAccessLayer dl = new DataAccessLayer();
        public int JobID { get; set; }
        public int VehicleID { get; set; }
        public int BookingID { get; set; }
        public string MechanicID { get; set; }
        public int TimeSheetID { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }
        public string PaymentType { get; set; }
        public bool PaymentStatus { get; set; }
        public bool Status { get; set; }

        //Creates a new job
        public int CreateJob(int VehicleID, int BookingID, DateTime BeginDate, string Notes, string PaymentType, bool PaymentStatus)
        {
            return dl.CreateJob(VehicleID, BookingID, BeginDate, Notes, PaymentType, PaymentStatus);
        }

        //View all active jobs
        public DataTable GetAllJobs()
        {
            return dl.GetAllJobs();
        }

        //View a specific job
        public DataTable GetJobsMechanic(string MechanicID)
        {
            return dl.GetJobsMechanic(MechanicID);
        }

        //Updates a job
        public int UpdateJobs(int JobID, DateTime EndDate, string Notes, bool PaymentStatus, bool Status)
        {
            return dl.UpdateJob(JobID, EndDate, Notes, PaymentStatus, Status);
        }

        //Assigns a mechanic to a job
        public int AssignMechanic(int JobID, string MechanicID)
        {
            return dl.AssignMechanic(JobID, MechanicID);
        }
    }
}