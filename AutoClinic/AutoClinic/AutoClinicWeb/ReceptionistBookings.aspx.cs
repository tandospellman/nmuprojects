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
    public partial class ReceptionistBookings : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);

        protected void Page_Load(object sender, EventArgs e)
        {
            //Displays Customer Names In Drop Down LIst
           /* string query = "SELECT * FROM CUSTOMERu";
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
            
           

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //This needs to show after button is clicked!!!
           /* IAutoClinic db = new DBAccess();
            DBHandler handler = new DBHandler(db);

            string customerID = cmbSearchOptions.SelectedValue.ToString();
            List<UspViewCustInfo> list = handler.ViewCustInfos(customerID);
            dgvSearchResults.DataSource = list; */
        }
    }
}