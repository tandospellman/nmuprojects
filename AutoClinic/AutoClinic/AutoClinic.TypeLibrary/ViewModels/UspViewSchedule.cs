using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClinic.TypeLibrary.ViewModels
{
    public class UspViewSchedule
    {
        public string MechanicID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public bool Status { get; set; }
    }
}
