using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Timers;
namespace AutoClinicWeb
{
    public partial class CustManageVehicles : System.Web.UI.Page

    {

        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        Vehicle vehicle = new Vehicle();

        protected void Page_Load(object sender, EventArgs e)
        {

         
        }

       

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            string searchValue = "", customerID = "";

            searchValue = txtRegNo.Text;


            //Returns customer information
            string query = "SELECT * FROM VEHICLE WHERE RegistrationNo = '" + searchValue + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txtSerial.Text = ValueCheck(dr["SerialNo"].ToString());
                    txtMake.Text = ValueCheck(dr["Make"].ToString());
                    txtModel.Text = ValueCheck(dr["Model"].ToString());
                    txtYear.Text = ValueCheck(dr["Year"].ToString());
                    txtMilage.Text = ValueCheck(dr["Milage"].ToString());
                    txtLastService.Text = ValueCheck(dr["PreviousServiceDate"].ToString());
                    txtCustomerID.Text = ValueCheck(dr["CustomerID"].ToString());
                    txtRegistration.Text = ValueCheck(dr["RegistrationNo"].ToString());
                }
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            if (String.IsNullOrEmpty(customerID))
            {
                lblNotFound.Text = "No record found. Make sure correct name is entered.";
            }
            else
            {
                lblNotFound.Text = "";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            /* TEMP COMMENT
            string customerID = txtCustomerID.Text,
               serialNo = txtSerial.Text,
               model = txtModel.Text,
               year = txtYear.Text,
               make = txtMake.Text,
               regNo = txtRegistration.Text;
            DateTime lastService = DateTime.ParseExact(txtLastService.Text.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            int milage = int.Parse(txtMilage.Text);

            int x = 0;


            string sqlUpdate = "UPDATE VEHICLE SET SerialNo = ISNULL('" + serialNo + "', SerialNo), "
                + "Make = ISNULL('" + make + "', Make), "
                + "Model = ISNULL('" + model + "', Model), "
                + "Year = ISNULL('" + year + "', Year), "
                + "Milage = ISNULL('" + milage + "', Milage), "
                + "PreviousServiceDate = ISNULL('" + lastService + "', PreviousServiceDate), "
                + "WHERE RegistrationNo = '" + regNo + "';";

            SqlCommand cmd = new SqlCommand(sqlUpdate, con);


            try
            {
                con.Open();
                x = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            if (x != 0)
                lblUpdateSuccess.Text = "Successfully Updated!";
            else
                lblUpdateSuccess.Text = "Update Failed!";
                */
        }
        

        public string ValueCheck(string value)
        {
            string result = "";

            if (value == "&nbsp;")
                result = "";
            else
                result = value;

            return result;
        }

    }
    
}