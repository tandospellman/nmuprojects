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
    public partial class CustBooking : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);

        
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM CUSTOMERu";
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
        }

        protected void btnReqQuote_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReceptionistQuoutes.aspx");
        }
    }
}