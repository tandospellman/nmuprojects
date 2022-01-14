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
    public partial class LoginPage : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        //LoginDetails ld = new LoginDetails();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //Loads the user's details into textboxes if they checked remember me in the previous session
            if (Request.Cookies["cookie"] != null)
            {
                if((Request.Cookies["cookie"]["Username"] != "") && (Request.Cookies["cookie"]["Password"] != ""))
                {
                    txtUsername.Text = Request.Cookies["cookie"]["Username"];
                    txtUsername.Text = Request.Cookies["cookie"]["Password"];
                }
            }
        }

        //Checks for empty strings sent through from the database
        public string ValueCheck(string value)
        {
            string result = "";

            if (value == "&nbsp;")
                result = "";
            else
                result = value;
            
            return result;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "", password = "";
            HttpCookie cookie = new HttpCookie("UserInfo");

            //Returns the selected customer's login details
            string sqlSelect = "SELECT * FROM LOGIN WHERE Username = '" + txtUsername.Text + "' AND [Password] = '" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txtCustomerID.Text = ValueCheck(dr["CustomerID"].ToString());
                    txtEmployeeID.Text = ValueCheck(dr["EmployeeID"].ToString());
                    username = ValueCheck(dr["Username"].ToString());
                    password = ValueCheck(dr["Password"].ToString());
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

            //Checks if username and password are valid
            if ((String.IsNullOrEmpty(txtCustomerID.Text)) && (String.IsNullOrEmpty(txtEmployeeID.Text)))
            {
                lblerrorLabel.Text = "Incorrect username or password entered";
            }
            else
            {
                if ((!String.IsNullOrEmpty(txtCustomerID.Text)))
                {
                    cookie["ID"] = txtCustomerID.Text;
                    cookie["AccountType"] = "Customer";
                    cookie["Username"] = "";
                    cookie["Password"] = "";
                }
                else if ((!String.IsNullOrEmpty(txtEmployeeID.Text)))
                {
                    cookie["ID"] = txtEmployeeID.Text;
                    cookie["AccountType"] = "Employee";
                    cookie["Username"] = "";
                    cookie["Password"] = "";
                }

                //Saves the user's login details for next session
                if (chkRememberMe.Checked)
                {
                    cookie["Username"] = username;
                    cookie["Password"] = password;

                    //Sets the cookie expiration time to 30 days
                    cookie.Expires = DateTime.Now.AddDays(30);
                }

                Response.Cookies.Add(cookie);
                Response.Redirect("~/Dashboard.aspx");
            }
        }
    }
}