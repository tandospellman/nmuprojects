using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AutoClinicWeb
{
    public partial class PasswordRecovery : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string customerID = "", employeeID = "";
            
            //Checks for the entered email in the customers table
            string sqlSelectIfCustomer = "SELECT CustomerID FROM CUSTOMERu WHERE Email = '" + txtEmail.Text + "'";
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.Connection = con;
            cmd.CommandText = sqlSelectIfCustomer;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    customerID = dr["CustomerID"].ToString();
                }

                dr.Close();
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            //Checks for the entered email in the employees table
            string sqlSelectIfEmployee = "SELECT EmployeeID FROM EMPLOYEEu WHERE Email = '" + txtEmail.Text + "'";
            cmd.CommandText = sqlSelectIfEmployee;
            cmd.Connection = con;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    employeeID = dr["EmployeeID"].ToString();
                }

                dr.Close();
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            if (string.IsNullOrEmpty(employeeID) && string.IsNullOrEmpty(customerID))
                lblNotFound.Text = "Account not found. Please re-enter email address."; 
        }
    }
}