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
    public partial class ViewVehicles : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        Vehicle vehicle = new Vehicle();

        protected void Page_Load(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT CONCAT(c.FirstName, ' ', c.Surname) AS [Customer Name], v.RegistrationNo AS [Registration Number], "
                + "v.Make AS [Make], v.Model AS [Model], v.PreviousServiceDate AS [Date Last Serviced] "
                + "FROM VEHICLE v, CUSTOMERu c WHERE v.CustomerID = c.CustomerID AND c.Active = 1; ";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                dgvActiveVehicles.DataSource = dr;
                dgvActiveVehicles.DataBind();
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }
        }
    }
}