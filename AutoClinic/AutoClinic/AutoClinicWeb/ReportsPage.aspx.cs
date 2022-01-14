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
    public partial class ReportsPage : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        ReportsClass rc = new ReportsClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            divReport1.Visible = false;
            dgvReports.Visible = false;
            divReport2.Visible = false;
        }

        protected void btnReport1_Click(object sender, EventArgs e)
        {
            divReport1.Visible = true;
        }

        protected void ddlMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = int.Parse(ddlMonth.SelectedValue.ToString());
            dgvReports.DataSource = rc.GetCompletedJobsMonth(month);
            dgvReports.DataBind();
            divReport1.Visible = true;
        }

        protected void ddlMechanic_SelectedIndexChanged(object sender, EventArgs e)
        {
            divReport2.Visible = true;
            string mechanicID = ddlMechanic.SelectedValue.ToString();
            dgvReports.DataSource = rc.GetDayForMechanic(mechanicID);
            dgvReports.DataBind();
            dgvReports.Visible = true;
        }

        protected void btnReport2_Click(object sender, EventArgs e)
        {
            divReport2.Visible = true;
            string query = "SELECT EmployeeID AS [Employee ID], CONCAT(FirstName, ' ', Surname) AS [Employee Name] FROM EMPLOYEEu WHERE EmployeeType = 1 AND Active = 1; ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            try
            {
                ddlMechanic.Items.Clear();
                ListItem newItem = new ListItem();
                newItem.Text = "Select a mechanic:";
                newItem.Value = "0";
                ddlMechanic.Items.Add(newItem);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    newItem = new ListItem();
                    newItem.Text = dr["Employee Name"].ToString();
                    newItem.Value = dr["Employee ID"].ToString();
                    ddlMechanic.Items.Add(newItem);
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
}