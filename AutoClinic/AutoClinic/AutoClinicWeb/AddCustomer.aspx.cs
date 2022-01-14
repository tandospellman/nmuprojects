using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

namespace AutoClinicWeb
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        Customer customer = new Customer();
        Vehicle vehicle = new Vehicle();

        protected void Page_Load(object sender, EventArgs e)
        {
            divVehicleInfo.Visible = false;
            btnCustomerInfo.Visible = false;
            btnRegister.Visible = false;
        }

        protected void btnVehicleInfo_Click(object sender, EventArgs e)
        {
            divCustomerInfo.Visible = false;
            divVehicleInfo.Visible = true;
            btnCustomerInfo.Visible = true;
            btnVehicleInfo.Visible = false;
            btnRegister.Visible = true;
        }

        protected void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            divCustomerInfo.Visible = true;
            divVehicleInfo.Visible = false;
            btnVehicleInfo.Visible = true;
            btnCustomerInfo.Visible = false;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text,
                surname = txtSurname.Text,
                phoneNumber = txtPhoneNo.Text,
                email = txtEmail.Text,
                regNo = txtRegNo.Text,
                make = txtMake.Text,
                model = txtModel.Text,
                year = txtYear.Text;
            string lastCusID = "", newCusID = "";
            int x = 0, y = 0, numberID, newVehicleID, lastVehicleID = 0;

            //Selects last customer id
            #region GetLastCustomerID()
            string sqlSelectLastCustomerID = "SELECT TOP 1 RIGHT(CustomerID, 9 ) AS [Customer ID] "
                + "FROM CUSTOMERu ORDER BY CustomerID DESC";
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlSelectLastCustomerID;
            cmd.Connection = con;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lastCusID = dr["Customer ID"].ToString();
                }

                dr.Close();
            }
            catch(Exception err)
            {

            }
            finally
            {
                con.Close();
            }
            #endregion GetLastCustomerID()

            //Creates new customer id
            numberID = int.Parse(lastCusID.Remove(0, 1)) + 1;
            newCusID = "c" + numberID.ToString();

            //Inserts new customer
            #region InsertCustomer()
            string sqlInsertCustomer = "INSERT INTO CUSTOMERu (CustomerID, FirstName, Surname, PhoneNo, Email, Active, AccountBalance) "
                + "VALUES ('" + newCusID + "', '" + firstName + "', '" + surname + "', '" + phoneNumber +  "', '" + email + "', 1, 0);";
            cmd.CommandText = sqlInsertCustomer;
            cmd.Connection = con;
            
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

            #endregion InsertCustomer()
            
            //Selects last vehicle id
            #region GetLastVehicleID()
            string selectLastVehicleID = "SELECT TOP 1 VehicleID FROM VEHICLE ORDER BY VehicleID DESC;";
            cmd.CommandText = selectLastVehicleID;
            cmd.Connection = con;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lastVehicleID = int.Parse(dr["VehicleID"].ToString());
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

            #endregion GetLastVehicleID()

            //Creates new vehicle id
            newVehicleID = lastVehicleID + 1;

            #region InsertVehicle()
            //Inserts new vehicle
            string sqlInsertVehicle = "INSERT INTO VEHICLE (VehicleID, CustomerID, RegistrationNo, Make, Model, [Year]) "
                + "VALUES ('" + newVehicleID + "', '" + newCusID + "', '" + regNo + "', '" + make + "', '" + model + "', '" + year + "')";
            cmd.CommandText = sqlInsertVehicle;
            cmd.Connection = con;

            try
            {
                con.Open();
                y = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            #endregion InsertVehicle()

            //Checks if both inserts worked
            if (x != 0 && y != 0)
            {
                lblRegistrationSuccess.Text = "Successfully Registration!";

                txtFirstName.Text = String.Empty;
                txtSurname.Text = String.Empty;
                txtPhoneNo.Text = String.Empty;
                txtEmail.Text = String.Empty;
                txtRegNo.Text = String.Empty;
                txtMake.Text = String.Empty;
                txtModel.Text = String.Empty;
                txtYear.Text = String.Empty;
            }
            else
            {
                lblRegistrationSuccess.Text = "Registration Failed!";
            }
        }
    }
}