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
    public partial class ViewQuote : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        QuoteClass q = new QuoteClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ddlSelectOption.Text != "View All")
            {
                dgvQuote.Visible = false;
            }
            //ddlSelectCustomer.Visible = false;
        }

        protected void ddlSelectOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSelectOption.Text == "View All")
            {
                dgvQuote.DataSource = q.GetAllQuotes();
                dgvQuote.DataBind();
                dgvQuote.Visible = true;
            }
            else if (ddlSelectOption.Text == "Search by Customer")
            {
                /*ddlSelectCustomer.Visible = true;
                dgvQuote.Visible = false;
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
                }*/
            }
        }

        protected void ddlSelectCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string customerID = ddlSelectCustomer.SelectedValue.ToString();
            dgvQuote.DataSource = q.GetQuoteCustomer(customerID);
            dgvQuote.DataBind();
            dgvQuote.Visible = true;
            ddlSelectCustomer.Visible = true;*/
        }
    }
}