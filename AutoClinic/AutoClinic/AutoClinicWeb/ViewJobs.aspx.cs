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
    public partial class ViewJobs : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        Jobs j = new Jobs();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (ddlSelectOption.Text == "Select an option:")
            {
                ddlSelectMechanic.Visible = false;
            }
        }

        protected void ddlSelectOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSelectOption.Text == "View All")
            {
                dgvJobss.DataSource = j.GetAllJobs();
                dgvJobss.DataBind();
            }
            else if (ddlSelectOption.Text == "View Mechanic")
            {
                dgvJobss.Visible = false;
                string query = "SELECT * FROM EMPLOYEEu WHERE EMPLOYEEu.EmployeeType = 1";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr;
                try
                {
                    ddlSelectMechanic.Items.Clear();
                    ListItem newItem = new ListItem();
                    newItem.Text = "Select a Mechanic:";
                    newItem.Value = "0";
                    ddlSelectMechanic.Items.Add(newItem);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        newItem = new ListItem();
                        newItem.Text = dr["FirstName"].ToString() + ' ' + dr["Surname"].ToString();
                        newItem.Value = dr["EmployeeID"].ToString();
                        ddlSelectMechanic.Items.Add(newItem);
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
                ddlSelectMechanic.Visible = true;

            }
        }

        protected void ddlSelectMechanic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mechanicID = ddlSelectMechanic.SelectedValue.ToString();
            dgvJobss.DataSource = j.GetJobsMechanic(mechanicID);
            dgvJobss.DataBind();
            dgvJobss.Visible = true;
        }
    }
}