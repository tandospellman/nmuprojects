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
    public partial class EditMechanic : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        Mechanic mechanic = new Mechanic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                dgvMechanics.Visible = false;
                divUpdateMechanic.Visible = false;
                btnUpdate.Visible = false;
                string query = "SELECT EmployeeID AS [Employee ID], CONCAT(FirstName, ' ', Surname) AS [Employee Name] FROM EMPLOYEEu WHERE EmployeeType = 1 AND Active = 1; ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr;

                try
                {
                    ddlSelectMechanic.Items.Clear();
                    ListItem newItem = new ListItem();
                    newItem.Text = "Select a mechanic:";
                    newItem.Value = "0";
                    ddlSelectMechanic.Items.Add(newItem);
                    con.Open();
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        newItem = new ListItem();
                        newItem.Text = dr["Employee Name"].ToString();
                        newItem.Value = dr["Employee ID"].ToString();
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
            }
        }

        protected void ddlSelectMechanic_SelectedIndexChanged(object sender, EventArgs e)
        {
            divUpdateMechanic.Visible = true;
            btnUpdate.Visible = true;
            
            string mechID = ddlSelectMechanic.SelectedValue.ToString();

            dgvMechanics.DataSource = mechanic.GetMechanicInfo(mechID);
            dgvMechanics.DataBind();

            txtName.Text = ValueCheck(dgvMechanics.Rows[0].Cells[0].Text);
            txtPhoneNumber.Text = ValueCheck(dgvMechanics.Rows[0].Cells[1].Text);
            txtEmail.Text = ValueCheck(dgvMechanics.Rows[0].Cells[2].Text);
            txtAddLine1.Text = ValueCheck(dgvMechanics.Rows[0].Cells[3].Text);
            txtAddLine2.Text = ValueCheck(dgvMechanics.Rows[0].Cells[4].Text);
            txtSuburb.Text = ValueCheck(dgvMechanics.Rows[0].Cells[5].Text);
            txtCity.Text = ValueCheck(dgvMechanics.Rows[0].Cells[6].Text);
            txtPostalCode.Text = ValueCheck(dgvMechanics.Rows[0].Cells[7].Text);

            ddlSelectMechanic.SelectedItem.Text = txtName.Text;
        }

        public string ValueCheck(string value)
        {
            string result = "";

            if (value == "&nbsp;")
                result = "";
            else
                result = value;

            return result;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string mechID = ddlSelectMechanic.SelectedValue.ToString(),
                phoneNumber = txtPhoneNumber.Text,
                email = txtEmail.Text,
                addLine1 = txtAddLine1.Text,
                addline2 = txtAddLine2.Text,
                suburb = txtSuburb.Text,
                city = txtCity.Text,
                postalCode = txtPostalCode.Text;

            int x = mechanic.UpdateMechanic(mechID, phoneNumber, email, addLine1, addline2, suburb, city, postalCode);

            if (x != 0)
                lblUpdateSuccess.Text = "Successfully Updated!";
            else
                lblUpdateSuccess.Text = "Update Failed!";
        }
    }
}