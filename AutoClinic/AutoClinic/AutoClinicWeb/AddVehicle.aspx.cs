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
    public partial class AddVehicle : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        Customer customer = new Customer();
        Vehicle vehicle = new Vehicle();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Loads ddlCustomers with customer names
            string sqlSelect = "SELECT CustomerID, CONCAT(FirstName, ' ', Surname) AS [Customer Name] FROM CUSTOMERu WHERE Active = '" + true + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr;

            try
            {
                ddlCustomers.Items.Clear();
                ListItem newItem = new ListItem();
                /*newItem.Text = "Select a Customer:";
                newItem.Value = "0";
                ddlCustomers.Items.Add(newItem);*/

                con.Open();
                dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    newItem = new ListItem();
                    newItem.Text = dr["Customer Name"].ToString();
                    newItem.Value = dr["CustomerID"].ToString();
                    ddlCustomers.Items.Add(newItem);
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
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string customerID = ddlCustomers.SelectedValue,
                regNo = txtRegNo.Text,
                make = txtMake.Text,
                model = txtModel.Text,
                year = txtYear.Text;
            int x = 0, newVehicleID, lastVehicleID = 0;

            //Selects last vehicle id
            #region GetLastVehicleID()
            string selectLastVehicleID = "SELECT TOP 1 VehicleID FROM VEHICLE ORDER BY VehicleID DESC;";
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
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
            string sqlInsertVehicle = "INSERT INTO VEHICLE (CustomerID, RegistrationNo, Make, Model, [Year]) "
                + "VALUES ('" + ddlCustomers.SelectedValue.ToString() + "', '" + regNo + "', '" + make + "', '" + model + "', '" + year + "')";
            cmd.CommandText = sqlInsertVehicle;
            cmd.Connection = con;

            try
            {
                con.Open();
                x = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                lblRegistrationSuccess.Text = err.ToString();
            }
            finally
            {
                con.Close();
            }

            #endregion InsertVehicle()

            //Checks if the vehicle was inserted
            if (x != 0)
            {
                lblRegistrationSuccess.Text = "Successfully Registration!";

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