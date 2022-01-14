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
    public partial class ViewBookings : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        BookingClass b = new BookingClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Hides when it shoudn't show
            if (ddlSelectOption.Text != "View by Customer")
            {
                ddlSelectCustomer.Visible = false;
            }
            if(ddlSelectOption.Text != "View by Vehicle")
            {
                ddlSelectVehicle.Visible = false;
            }
            
        }

        protected void ddlSelectOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When option is selected shows all bookings that are active
            if (ddlSelectOption.Text == "View All")
            {
                dgvBookings.DataSource = b.GetAllBookings();
                dgvBookings.DataBind();
            }
            
            //When option is selected shows the customer names
            else if (ddlSelectOption.Text == "View by Customer")
            {
                //Shows this dropdownlist
                ddlSelectCustomer.Visible = true;
                //Hides grid
                dgvBookings.Visible = false;
                //Shows a list of all the customers by name
                string query = "SELECT * FROM CUSTOMERu";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr;
                try
                {
                    ddlSelectCustomer.Items.Clear();
                    ListItem newItem = new ListItem();
                    newItem.Text = "Select a Customer:";
                    newItem.Value = "0";
                    ddlSelectCustomer.Items.Add(newItem);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        newItem = new ListItem();
                        newItem.Text = dr["FirstName"].ToString();
                        newItem.Value = dr["CustomerID"].ToString();
                        ddlSelectCustomer.Items.Add(newItem);
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
            else if (ddlSelectOption.Text == "View by Vehicle")
            {
                //Shows this dropdownlist
                ddlSelectVehicle.Visible = true;
                //Hides grid it is was visible
                dgvBookings.Visible = false;
                //Shows a list of all the vehicles
                string query = "SELECT * FROM VEHICLE";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr;
                try
                {
                    ddlSelectVehicle.Items.Clear();
                    ListItem newItem = new ListItem();
                    newItem.Text = "Select a Vehicle:";
                    newItem.Value = "0";
                    ddlSelectVehicle.Items.Add(newItem);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        newItem = new ListItem();
                        newItem.Text = dr["VehicleID"].ToString();
                        newItem.Value = dr["VehicleID"].ToString();
                        ddlSelectVehicle.Items.Add(newItem);
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
        }

        protected void ddlSelectCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerID = ddlSelectCustomer.SelectedValue.ToString();
            dgvBookings.DataSource = b.GetBookingCustomer(customerID);
            dgvBookings.DataBind();
            dgvBookings.Visible = true;
        }

        protected void ddlSelectVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vehicleID = Convert.ToInt32(ddlSelectVehicle.SelectedValue.ToString());
            dgvBookings.DataSource = b.GetBookingVehicle(vehicleID);
            dgvBookings.DataBind();
            dgvBookings.Visible = true;
        }
    }
}