using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using AutoClinic.BLL;
//using AutoClinic.DAL;
//using AutoClinic.TypeLibrary.Interfaces;
//using AutoClinic.TypeLibrary.Models;
//using AutoClinic.TypeLibrary.ViewModels;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AutoClinicWeb
{
    public partial class ReceptionistEditBooking : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);

        BookingClass b = new BookingClass();

        protected void Page_Load(object sender, EventArgs e)
        {

            //dgvBookings.DataSource = b.GetAllBookings();


            //Displays Customer Names In Drop Down LIst
         /*   string query = "SELECT * FROM CUSTOMERu";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            try
            {
                cmbSearchOptions.Items.Clear();
                ListItem newItem = new ListItem();
                newItem.Text = "<Select Customer>";
                newItem.Value = "0";
                cmbSearchOptions.Items.Add(newItem);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    newItem = new ListItem();
                    newItem.Text = dr["FirstName"].ToString();
                    newItem.Value = dr["CustomerID"].ToString();
                    cmbSearchOptions.Items.Add(newItem);
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
            */

          /*  IAutoClinic db = new DBAccess();
            DBHandler handler = new DBHandler(db);
            Booking booking = new Booking();

            booking.CustomerID = cmbSearchOptions.SelectedValue.ToString();
            booking.VehicleID = Convert.ToInt32(txtVehicleReg.Text);
            if (radGeneralRepair.Checked == true)
                booking.ServiceID = Convert.ToInt32("1");
            else if (radScheduledService.Checked == true)
                booking.ServiceID = Convert.ToInt32("2");
            else
                booking.ServiceID = Convert.ToInt32("5");
            booking.DateIn = Convert.ToDateTime(txtServiceDate.Text);
            booking.Comment = txtComment.Text;
            if (chkArrived.Checked == true)
                booking.Arrived = true;
            else
                booking.Arrived = false;
            if (db.BookAppointment(booking) == true)
            {
                //worked
            }
            else
            {
                //didn't work
            }
            */

        }
    }
}