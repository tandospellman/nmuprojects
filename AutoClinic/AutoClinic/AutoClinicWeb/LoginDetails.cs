using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AutoClinicWeb
{
    public class LoginDetails
    {

        /*
         * 
         * Receptionist Gmail Login Details
         * 
         * receptionist.autoclinic@gmail.com
         * Password2019
         * 
         */
        DataAccessLayer dl = new DataAccessLayer();
        public string Username { get; set; }
        public string Password { get; set; }
        public int AccountType { get; set; }

        //Returns all active logins
        public DataTable GetLogins()
        {
            return dl.GetLogins();
        }
    }
}