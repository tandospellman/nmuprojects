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
    public partial class ViewCustomers : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        Customer customer = new Customer();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Hides when it shouldn't show
            if (ddlSelectOption.Text != "Search by Customer")
            {
                divSearchButton.Visible = false;
                divSearchByCustomerName.Visible = false;
            }
            if (ddlSelectOption.Text != "Search by Vehicle")
            {
                divSearchByVehicleRegNo.Visible = false;
                divSearchButton.Visible = false;
            }
                
        }

        protected void ddlSelectOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When option is selected, shows all active customers
            if (ddlSelectOption.Text == "View All")
            {
                dgvCustomers.DataSource = customer.GetAllActiveCustomers();
                dgvCustomers.DataBind();
            }

            //When option is selected, shows customer name search bar
            else if (ddlSelectOption.Text == "Search by Customer")
            {
                //Shows search bar
                divSearchByCustomerName.Visible = true;
                divSearchButton.Visible = true;
                //Hides grid
                dgvCustomers.Visible = false;
            }

            //When option is selected, shows vehicle reg search bar
            else if (ddlSelectOption.Text == "Search by Vehicle")
            {
                //Shows search bar
                divSearchByVehicleRegNo.Visible = true;
                divSearchButton.Visible = true;
                //Hides grid
                dgvCustomers.Visible = false;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string[] customerNames;
            string searchValue = "";

            //Searches for a customer by their name
            if (ddlSelectOption.Text == "Search by Customer")
            {
                searchValue = txtName.Text;
                customerNames = searchValue.Split(' ');

                if (customerNames.Length > 1)
                {
                    dgvCustomers.DataSource = customer.GetCustomerByName(customerNames[0], customerNames[1]);
                    dgvCustomers.DataBind();
                }
            }
            //Searches for a customer by their reg no
            else if (ddlSelectOption.Text == "Search by Vehicle")
            {
                searchValue = txtRegNo.Text;

                dgvCustomers.DataSource = customer.GetCustomersByVehicle(searchValue);
                dgvCustomers.DataBind();
            }

            //Checks to see if dgvCustomers has data
            if (dgvCustomers.Rows.Count < 1)
            {
                lblNotFound.Text = "No record found. Make sure correct data is entered.";
            }
            else
            {
                lblNotFound.Text = " ";
                dgvCustomers.Visible = true;
            }

            divSearchButton.Visible = true;
        }
    }
}