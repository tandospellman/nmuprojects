using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace AutoClinicWeb
{
    public class ReportsClass
    {
        DataAccessLayer dl = new DataAccessLayer();
        public int Month { get; set; }
        public string MechanicID { get; set; }

        //Returns Jobs Completed that month
        public DataTable GetCompletedJobsMonth(int Month)
        {
            return dl.GetCompletedJobsMonth(Month);
        }

        //Returns Totals days work and avg day per job for a mechanic
        public DataTable GetDayForMechanic(string MechanicID)
        {
            return dl.GetDayForMechanic(MechanicID);
        }
    }
}