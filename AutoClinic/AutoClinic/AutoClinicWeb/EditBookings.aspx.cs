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
    public partial class EditBookings : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        BookingClass b = new BookingClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            ddlSelectBooking.Visible = false;
            dgvBookings.Visible = false;
            divNewBooking.Visible = false;
            btnContinue.Visible = false;
            divUpdateBooking.Visible = false;
            btnUpdate.Visible = false;
            lblUpdateSuccess.Visible = false;
            lblSuccess.Visible = false;
        }

        protected void ddlSelectBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlSelectBooking.Visible = true;
            int bookingID = Convert.ToInt32(ddlSelectBooking.SelectedValue.ToString());
            dgvBookings.DataSource = b.GetSelectedBooking(bookingID);
            dgvBookings.DataBind();
            dgvBookings.Visible = true;
            divUpdateBooking.Visible = true;

            lblCustomer.Text = dgvBookings.Rows[0].Cells[1].Text;
            lblVehicle.Text = dgvBookings.Rows[0].Cells[2].Text;
            lblService.Text = dgvBookings.Rows[0].Cells[3].Text;
            lblDateIn.Text = dgvBookings.Rows[0].Cells[4].Text;
            lblDateOut.Text = dgvBookings.Rows[0].Cells[5].Text;
            lblComment.Text = dgvBookings.Rows[0].Cells[6].Text;
        }

        protected void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BOOKING WHERE Active = '" + true +"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            try
            {
                ddlSelectBooking.Items.Clear();
                ListItem newItem = new ListItem();
                newItem.Text = "Select a Booking:";
                newItem.Value = "0";
                ddlSelectBooking.Items.Add(newItem);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    newItem = new ListItem();
                    newItem.Text = dr["BookingID"].ToString();
                    newItem.Value = dr["BookingID"].ToString();
                    ddlSelectBooking.Items.Add(newItem);
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
            ddlSelectBooking.Visible = true;
            divUpdateBooking.Visible = true;
            //Fills Customer DropDownList
            query = "SELECT * FROM CUSTOMERu";
            cmd = new SqlCommand(query, con);
            try
            {
                ddlCustomerUp.Items.Clear();
                ListItem newItem = new ListItem();
                newItem.Text = "Select a Customer:";
                newItem.Value = "0";
                ddlCustomerUp.Items.Add(newItem);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    newItem = new ListItem();
                    newItem.Text = dr["FirstName"].ToString() + ' ' + dr["Surname"];
                    newItem.Value = dr["CustomerID"].ToString();
                    ddlCustomerUp.Items.Add(newItem);
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
            //Fills Vehicle DropDownList
            query = "SELECT * FROM VEHICLE";
            cmd = new SqlCommand(query, con);
            try
            {
                ddlVehicleUp.Items.Clear();
                ListItem newItem = new ListItem();
                newItem.Text = "Select the Vehicle:";
                newItem.Value = "0";
                ddlVehicleUp.Items.Add(newItem);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    newItem = new ListItem();
                    newItem.Text = dr["VehicleID"].ToString();
                    newItem.Value = dr["VehicleID"].ToString();
                    ddlVehicleUp.Items.Add(newItem);
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
            //Fills Service DropDownList
            query = "SELECT * FROM SERVICE";
            cmd = new SqlCommand(query, con);
            try
            {
                ddlServiceUp.Items.Clear();
                ListItem newItem = new ListItem();
                newItem.Text = "Select Service Type:";
                newItem.Value = "0";
                ddlServiceUp.Items.Add(newItem);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    newItem = new ListItem();
                    newItem.Text = dr["ServiceName"].ToString();
                    newItem.Value = dr["ServiceID"].ToString();
                    ddlServiceUp.Items.Add(newItem);
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
            btnUpdate.Visible = true;
        }

        protected void btnCreateNew_Click(object sender, EventArgs e)
        {
            divNewBooking.Visible = true;
            //Fills Customer DropDownList
            string query = "SELECT * FROM CUSTOMERu";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            try
            {
                ddlCustomer.Items.Clear();
                ListItem newItem = new ListItem();
                newItem.Text = "Select a Customer:";
                newItem.Value = "0";
                ddlCustomer.Items.Add(newItem);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    newItem = new ListItem();
                    newItem.Text = dr["FirstName"].ToString() + ' ' + dr["Surname"];
                    newItem.Value = dr["CustomerID"].ToString();
                    ddlCustomer.Items.Add(newItem);
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
            //Fills Vehicle DropDownList
            query = "SELECT * FROM VEHICLE";
            cmd = new SqlCommand(query, con);
            try
            {
                ddlVehicle.Items.Clear();
                ListItem newItem = new ListItem();
                newItem.Text = "Select the Vehicle:";
                newItem.Value = "0";
                ddlVehicle.Items.Add(newItem);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    newItem = new ListItem();
                    newItem.Text = dr["VehicleID"].ToString();
                    newItem.Value = dr["VehicleID"].ToString();
                    ddlVehicle.Items.Add(newItem);
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
            //Fills Service DropDownList
            query = "SELECT * FROM SERVICE";
            cmd = new SqlCommand(query, con);
            try
            {
                ddlService.Items.Clear();
                ListItem newItem = new ListItem();
                newItem.Text = "Select Service Type:";
                newItem.Value = "0";
                ddlService.Items.Add(newItem);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    newItem = new ListItem();
                    newItem.Text = dr["ServiceName"].ToString();
                    newItem.Value = dr["ServiceID"].ToString();
                    ddlService.Items.Add(newItem);
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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (ddlCustomer.Text == "Select a Customer:" || ddlVehicle.Text == "Select the Vehicle:" || ddlService.Text == "Select Service Type:" || txtDateIn.Text == "")
            {
                lblSuccess.Text = "Data Entry Error! Please Select or enter the correct Data.";
                lblSuccess.Visible = true;
                divNewBooking.Visible = true;
                lblSuccess.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                int x = 0;
                if (chkArrived.Checked == true)
                {
                    x = b.CreateBooking(ddlCustomer.SelectedValue.ToString(), int.Parse(ddlVehicle.SelectedValue.ToString()), int.Parse(ddlService.SelectedValue.ToString()), DateTime.Parse(txtDateIn.Text.ToString()), txtComment.Text, true, true);
                }
                else if (chkArrived.Checked == false)
                {
                    x = b.CreateBooking(ddlCustomer.SelectedValue.ToString(), int.Parse(ddlVehicle.SelectedValue.ToString()), int.Parse(ddlService.SelectedValue.ToString()), DateTime.Parse(txtDateIn.Text.ToString()), txtComment.Text, false, true);
                }
                if (x != 0)
                {
                    lblSuccess.ForeColor = System.Drawing.Color.Green;
                    lblSuccess.Text = "Booking Successfully Created!";
                }
                else
                {
                    lblSuccess.ForeColor = System.Drawing.Color.Red;
                    lblSuccess.Text = "Booking Error!";
                }
                divNewBooking.Visible = false;
                lblSuccess.Visible = true;
                btnContinue.Visible = true;
            }
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            lblSuccess.Visible = false;
            btnContinue.Visible = false;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ddlSelectBooking.Text == "Select a Booking:" || ddlCustomerUp.Text == "Select a Customer:" || ddlVehicleUp.Text == "Select the Vehicle:" || ddlServiceUp.Text == "Select Service Type:" || txtDateInUp.Text == "" || txtDateOutUp.Text == "")
            {
                lblUpdateSuccess.Text = "Data Entry Error! Please Select or enter the correct Data.";
                lblUpdateSuccess.ForeColor = System.Drawing.Color.Red;
                lblUpdateSuccess.Visible = true;
                divUpdateBooking.Visible = true;
                ddlSelectBooking.Visible = true;
                btnUpdate.Visible = true;
            }
            else
            {
                int bookingID = int.Parse(ddlSelectBooking.SelectedValue);
                int x = 0;
                if (chkArrivedUp.Checked == true && chkActiveUp.Checked == true)
                {
                    x = b.UpdateBooking(bookingID, ddlCustomerUp.SelectedValue.ToString(), int.Parse(ddlVehicleUp.SelectedValue.ToString()), int.Parse(ddlServiceUp.SelectedValue.ToString()), DateTime.Parse(txtDateInUp.Text.ToString()), DateTime.Parse(txtDateOutUp.Text.ToString()), txtCommentUp.Text, true, true);
                }
                else if (chkArrivedUp.Checked == false && chkActiveUp.Checked == true)
                {
                    x = b.UpdateBooking(bookingID, ddlCustomerUp.SelectedValue.ToString(), int.Parse(ddlVehicleUp.SelectedValue.ToString()), int.Parse(ddlServiceUp.SelectedValue.ToString()), DateTime.Parse(txtDateInUp.Text.ToString()), DateTime.Parse(txtDateOutUp.Text.ToString()), txtCommentUp.Text, false, true);
                }
                else if (chkArrivedUp.Checked == false && chkActiveUp.Checked == false)
                {
                    x = b.UpdateBooking(bookingID, ddlCustomerUp.SelectedValue.ToString(), int.Parse(ddlVehicleUp.SelectedValue.ToString()), int.Parse(ddlServiceUp.SelectedValue.ToString()), DateTime.Parse(txtDateInUp.Text.ToString()), DateTime.Parse(txtDateOutUp.Text.ToString()), txtCommentUp.Text, false, true);
                }
                else if (chkArrivedUp.Checked == true && chkActiveUp.Checked == false)
                {
                    x = b.UpdateBooking(bookingID, ddlCustomerUp.SelectedValue.ToString(), int.Parse(ddlVehicleUp.SelectedValue.ToString()), int.Parse(ddlServiceUp.SelectedValue.ToString()), DateTime.Parse(txtDateInUp.Text.ToString()), DateTime.Parse(txtDateOutUp.Text.ToString()), txtCommentUp.Text, true, false);
                }
                if (x != 0)
                {
                    lblUpdateSuccess.ForeColor = System.Drawing.Color.Green;
                    lblUpdateSuccess.Text = "Successfully Updated!";
                }
                else
                {
                    lblUpdateSuccess.ForeColor = System.Drawing.Color.Red;
                    lblUpdateSuccess.Text = "Failed Update!";
                }
            }
        }

        protected void dgvBookings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}