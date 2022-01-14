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
    public partial class MyAccount : System.Web.UI.Page

    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        Customer c = new Customer();

      
       protected void Page_Load(object sender, EventArgs e)
        {


            //only search name for customer info
            /**divSearchByCustomerName.Visible = true;
            divSearchButton.Visible = true;
            dgvCustomers.Visible = true;
            **/
            divCustomerAddressInfo.Visible = false;
            divCustomerPersonalInfo.Visible = false;
            btnNextPage.Visible = false;
            btnPreviousPage.Visible = false;
            btnUpdate.Visible = false;

            //cust invisiblefields
            

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {




          /**  int customerID = int.Parse(txtIDNumber.Text);
           int x = 0;
            x = c.UpdateCustomerInfo(customerID.ToString(), txtFirstName.Text.ToString(), txtSurname.Text.ToString(), DateTime.Parse(txtDOB.Text.ToString()), txtPhoneNumber.Text.ToString(), txtEmail.Text.ToString(), txtAddLine1.Text.ToString(), txtAddLine2.Text.ToString(), txtSuburb.Text.ToString(), txtCity.Text.ToString(), txtProvince.Text.ToString(), txtPostalCode.Text.ToString(), int.Parse(txtActive.Text.ToString()), int.Parse(txtAccBal.Text.ToString()));
        
            **/

        }
      
      

        protected void btnUpdate_Click1(object sender, EventArgs e)
        {

            //links to edit info page
            Response.Redirect("EditCustomer.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {


            string[] customerNames;
            string searchValue = "";

            searchValue = txtCustomerName.Text;
            customerNames = searchValue.Split(' ');

            if (customerNames.Length > 1)
            {
                //Returns customer information
                string query = "SELECT * FROM CUSTOMERu WHERE FirstName = '" + customerNames[0] + "' AND Surname = '" + customerNames[1] + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr;

                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        txtCustomerID.Text = ValueCheck(dr["CustomerID"].ToString());
                        txtFirstName.Text = ValueCheck(dr["FirstName"].ToString());
                        txtSurname.Text = ValueCheck(dr["Surname"].ToString());
                        txtDOB.Text = ValueCheck(dr["DateOfBirth"].ToString());
                        txtPhoneNo.Text = ValueCheck(dr["PhoneNo"].ToString());
                        txtEmail.Text = ValueCheck(dr["Email"].ToString());
                        txtAddLine1.Text = ValueCheck(dr["AddressLine1"].ToString());
                        txtAddLine2.Text = ValueCheck(dr["AddressLine2"].ToString());
                        txtSuburb.Text = ValueCheck(dr["Suburb"].ToString());
                        txtCity.Text = ValueCheck(dr["City"].ToString());
                        txtProvince.Text = ValueCheck(dr["Province"].ToString());
                        txtPostalCode.Text = ValueCheck(dr["PostalCode"].ToString());
                        //customer password
                        txtPassword.Text = ValueCheck(dr["Password"].ToString());

                       // if (dr["Active"].ToString() == "1")
                        //    ddlActive.SelectedIndex = 1;
                      //  else
                       //     ddlActive.SelectedIndex = 0;
                       //no balance viewable for customer
                      //  txtBalance.Text = dr["AccountBalance"].ToString();
                    }
                }
                catch (Exception err)
                {

                }
                finally
                {
                    con.Close();
                }

                if (String.IsNullOrEmpty(txtFirstName.Text))
                {
                    lblNotFound.Text = "No record found. Make sure correct name is entered.";
                }
                else
                {
                    lblNotFound.Text = "";
                    divCustomerPersonalInfo.Visible = true;
                    btnNextPage.Visible = true;
                    btnUpdate.Visible = true;
                }
            }
            else
            {
                lblNotFound.Text = "No record found. Make sure correct name is entered.";
            }

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

        protected void btnNextPage_Click(object sender, EventArgs e)
        {
            divCustomerPersonalInfo.Visible = false;
            divCustomerAddressInfo.Visible = true;
            btnPreviousPage.Visible = true;
            btnNextPage.Visible = false;
            btnUpdate.Visible = true;
        }

        protected void btnPreviousPage_Click(object sender, EventArgs e)
        {
            divCustomerPersonalInfo.Visible = true;
            divCustomerAddressInfo.Visible = false;
            btnPreviousPage.Visible = false;
            btnNextPage.Visible = true;
            btnUpdate.Visible = true;
        }


        protected void btnUpdate_Click(object sender, EventArgs e)
        {
          /*  TEMP COMMENT 
           *  string customerID = txtCustomerID.Text,
                firstName = txtFirstName.Text,
                surname = txtSurname.Text,
                phoneNo = txtPhoneNo.Text,
                email = txtEmail.Text,
                addLine1 = txtAddLine1.Text,
                addLine2 = txtAddLine2.Text,
                suburb = txtSuburb.Text,
                city = txtCity.Text,
                province = txtProvince.Text,
                postalCode = txtPostalCode.Text;
            DateTime dateOfBirth = DateTime.ParseExact(txtDOB.Text.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            double balance = double.Parse(txtBalance.Text);
            int active = int.Parse(ddlActive.SelectedValue);

            int x = 0;


            string sqlUpdate = "UPDATE CUSTOMERu SET FirstName = ISNULL('" + firstName + "', FirstName), "
                + "Surname = ISNULL('" + surname + "', Surname), "
                + "DateOfBirth = ISNULL('" + dateOfBirth + "', DateOfBirth), "
                + "PhoneNo = ISNULL('" + phoneNo + "', PhoneNo), "
                + "Email = ISNULL('" + email + "', Email), "
                + "AddressLine1 = ISNULL('" + addLine1 + "', AddressLine1), "
                + "AddressLine2 = ISNULL('" + addLine2 + "', AddressLine2), "
                + "Suburb = ISNULL('" + suburb + "', Suburb), "
                + "City = ISNULL('" + city + "', City), "
                + "PostalCode = ISNULL('" + postalCode + "', PostalCode), "
                + "Active = ISNULL('" + active + "' , Active), "
                + "AccountBalance = ISNULL('" + balance + "', AccountBalance) "
                + "WHERE CustomerID = '" + customerID + "' AND Active = 1;";

            SqlCommand cmd = new SqlCommand(sqlUpdate, con);


            try
            {
                con.Open();
                x = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            if (x != 0)
                lblUpdateSuccess.Text = "Successfully Updated!";
            else
                lblUpdateSuccess.Text = "Update Failed!";
                */
        }
    }
}