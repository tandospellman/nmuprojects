using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace AutoClinicWeb
{
    public partial class Home : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        string userID, accountType;

        protected void Page_Load(object sender, EventArgs e)
        {
            string sqlSelect = "", userFirstName = "";
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if (cookie != null)
            {
                userID = cookie["ID"];
                accountType = cookie["AccountType"];
            }

            //Searches for customer details
            if (accountType == "Employee")
                sqlSelect = "SELECT FirstName AS [First Name] FROM EMPLOYEE WHERE EmployeeID = '" + userID + "', EmployeeType = '" + 2 + "'";
            else if (accountType == "Customer")
                sqlSelect = "SELECT FirstName FROM CUSTOMERu WHERE CustomerID = '" + userID + "'";


            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    userFirstName = "Welcome, " + dr["First Name"];
                }

                dr.Close();
            }
            catch  (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            //Hides specific pages depending on who is logged in, will set it once I know page names
            if (accountType == "Customer")
            {
                //Get page names from Tando
            }
            else if (accountType == "Employee")
            {
                //My pages and Seren's
            }
        }
    }
}