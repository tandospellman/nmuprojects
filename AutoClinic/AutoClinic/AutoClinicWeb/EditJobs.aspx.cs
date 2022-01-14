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
    public partial class EditJobs : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        Jobs j = new Jobs();

        protected void Page_Load(object sender, EventArgs e)
        {
            divAddJob.Visible = false;
            btnContinue.Visible = false;
            divUpdateJob.Visible = false;
            btnUpdateSelectedJob.Visible = false;
            lblSuccess.Visible = false;
            lblUpdateSuccess.Visible = false;
            divAssignMech.Visible = false;
            //btnUpdateSelectedJob.Visible = false;
            btnAssignMechJob.Visible = false;
        }

        protected void btnCreateNew_Click(object sender, EventArgs e)
        {
            divAddJob.Visible = true;
            //Fills Vehicle DropDownList
            string query = "SELECT * FROM VEHICLE";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
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
            //Fills Booking DropDownList
            query = "SELECT * FROM BOOKING";
            cmd = new SqlCommand(query, con);
            try
            {
                ddlBooking.Items.Clear();
                ListItem newItem = new ListItem();
                newItem.Text = "Select the Booking:";
                newItem.Value = "0";
                ddlBooking.Items.Add(newItem);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    newItem = new ListItem();
                    newItem.Text = dr["BookingID"].ToString();
                    newItem.Value = dr["BookingID"].ToString();
                    ddlBooking.Items.Add(newItem);
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

        //Change name error. IS FOR UPDATING BOOKING CLICK!!!
        protected void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            divUpdateJob.Visible = true;
            btnUpdateSelectedJob.Visible = true;
            //Fills JobID drop down list
            string query = "SELECT * FROM JOB_CARD WHERE Status = '" + false + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            try
            {
                ddlJobID.Items.Clear();
                ListItem newItem = new ListItem();
                newItem.Text = "Select a Job:";
                newItem.Value = "0";
                ddlJobID.Items.Add(newItem);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    newItem = new ListItem();
                    newItem.Text = dr["JobID"].ToString();
                    newItem.Value = dr["JobID"].ToString();
                    ddlJobID.Items.Add(newItem);
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

        protected void btnAssignMechanic_Click(object sender, EventArgs e)
        {
            divAssignMech.Visible = true;
            btnAssignMechJob.Visible = true;
            //Fills JobID drop down list
            string query = "SELECT * FROM JOB_CARD WHERE Status = '" + false + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            try
            {
                ddlJobIDMech.Items.Clear();
                ListItem newItem = new ListItem();
                newItem.Text = "Select the Job ID:";
                newItem.Value = "0";
                ddlJobIDMech.Items.Add(newItem);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    newItem = new ListItem();
                    newItem.Text = dr["JobID"].ToString();
                    newItem.Value = dr["JobID"].ToString();
                    ddlJobIDMech.Items.Add(newItem);
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
            query = "SELECT EmployeeID AS [Employee ID], CONCAT(FirstName, ' ', Surname) AS [Employee Name] FROM EMPLOYEEu WHERE EmployeeType = 1 AND Active = 1; ";
            cmd = new SqlCommand(query, con);
            try
            {
                ddlMechanicToJob.Items.Clear();
                ListItem newItem = new ListItem();
                newItem.Text = "Select a Mechanic:";
                newItem.Value = "0";
                ddlMechanicToJob.Items.Add(newItem);
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    newItem = new ListItem();
                    newItem.Text = dr["Employee Name"].ToString();
                    newItem.Value = dr["Employee ID"].ToString();
                    ddlMechanicToJob.Items.Add(newItem);
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
            if (ddlVehicle.Text == "Select the Vehicle:" || ddlBooking.Text == "Select the Booking:" || txtDateIn.Text == "" || ddlPaymentType.Text == "Select a Payment Type:")
            {
                lblSuccess.Text = "Data Entry Error! Please Select or enter the correct Data.";
                lblSuccess.ForeColor = System.Drawing.Color.Red;
                lblSuccess.Visible = true;
                divAddJob.Visible = true;
            }
            else
            {
                int x = 0;
                if (chkPayed.Checked == true)
                {
                    x = j.CreateJob(int.Parse(ddlVehicle.SelectedValue.ToString()), int.Parse(ddlBooking.SelectedValue.ToString()), DateTime.Parse(txtDateIn.Text), txtNotes.Text, ddlPaymentType.SelectedValue.ToString(), true);
                }
                else if (chkPayed.Checked == false)
                {
                    x = j.CreateJob(int.Parse(ddlVehicle.SelectedValue.ToString()), int.Parse(ddlBooking.SelectedValue.ToString()), DateTime.Parse(txtDateIn.Text), txtNotes.Text, ddlPaymentType.SelectedValue.ToString(), false);
                }
                if (x != 0)
                {
                    lblSuccess.ForeColor = System.Drawing.Color.Green;
                    lblSuccess.Text = "Job Successfully Created!";
                }
                else
                {
                    lblSuccess.ForeColor = System.Drawing.Color.Red;
                    lblSuccess.Text = "Job Error!";
                }
                divAddJob.Visible = false;
                btnContinue.Visible = true;
                lblSuccess.Visible = true;
            }
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            lblSuccess.Visible = false;
            btnContinue.Visible = false;
        }

        protected void btnUpdateSelectedJob_Click(object sender, EventArgs e)
        {
            if (ddlJobID.Text == "Select a Job:" || txtDateOut.Text == "")
            {
                lblUpdateSuccess.Text = "Data Entry Error! Please Select or enter the correct Data.";
                lblUpdateSuccess.ForeColor = System.Drawing.Color.Red;
                lblUpdateSuccess.Visible = true;
                divUpdateJob.Visible = true;
                btnUpdateSelectedJob.Visible = true;
            }
            else
            {
                int x = 0;
                if (chkPaymentStatusUp.Checked == true && chkJobStatus.Checked == true)
                {
                    j.UpdateJobs(int.Parse(ddlJobID.SelectedValue.ToString()), DateTime.Parse(txtDateOut.Text.ToString()), txtNotesUp.Text.ToString(), true, true);
                    //j.UpdateJobs(7, DateTime.Parse("1996-07-01"), "hi", true, true);
                }
                else if (chkPaymentStatusUp.Checked == false && chkJobStatus.Checked == true)
                {
                    j.UpdateJobs(int.Parse(ddlJobID.SelectedValue.ToString()), DateTime.Parse(txtDateOut.Text.ToString()), txtNotesUp.Text.ToString(), false, true);
                }
                else if (chkPaymentStatusUp.Checked == false && chkJobStatus.Checked == false)
                {
                    j.UpdateJobs(int.Parse(ddlJobID.SelectedValue.ToString()), DateTime.Parse(txtDateOut.Text.ToString()), txtNotesUp.Text.ToString(), false, false);
                }
                else if (chkPaymentStatusUp.Checked == true && chkJobStatus.Checked == false)
                {
                    j.UpdateJobs(int.Parse(ddlJobID.SelectedValue.ToString()), DateTime.Parse(txtDateOut.Text.ToString()), txtNotesUp.Text.ToString(), true, false);
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

        protected void btnAssignMechJob_Click(object sender, EventArgs e)
        {
            if (ddlJobIDMech.Text == "Select the Job ID:" || ddlMechanicToJob.Text == "Select a Mechanic:")
            {
                lblSuccessAssign.Text = "Data Entry Error! Please Select or enter the correct Data.";
                lblSuccessAssign.ForeColor = System.Drawing.Color.Red;
                lblSuccessAssign.Visible = true;
                btnAssignMechJob.Visible = true;
                divAssignMech.Visible = true;
            }
            else
            {
                int x = j.AssignMechanic(int.Parse(ddlJobIDMech.SelectedValue.ToString()), ddlMechanicToJob.SelectedValue.ToString());
                if (x != 0)
                {
                    lblSuccessAssign.ForeColor = System.Drawing.Color.Green;
                    lblSuccessAssign.Text = "Successfully Updated!";
                }
                else
                {
                    lblSuccessAssign.ForeColor = System.Drawing.Color.Red;
                    lblSuccessAssign.Text = "Failed Updated!";
                }
            }
        }
    }
}