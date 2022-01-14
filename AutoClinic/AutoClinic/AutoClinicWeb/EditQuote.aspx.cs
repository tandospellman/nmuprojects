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
    public partial class EditQuote : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        QuoteClass q = new QuoteClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDateCreated.Text == "" || txtTotalCost.Text == "" || txtDiscount.Text == "")
            {
                lblSuccess.Text = "Data Entry Error! Please Select or enter the correct Data.";
                lblSuccess.Visible = true;
                lblSuccess.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                int x = 0;
                DateTime dt = DateTime.Parse(txtDateCreated.Text.ToString());
                DateTime expDate = dt.AddMonths(1);
                if (chkStatus.Checked == true)
                {
                    x = q.CreateQuote(DateTime.Parse(txtDateCreated.Text.ToString()), expDate, float.Parse(txtTotalCost.Text.ToString()), float.Parse(txtDiscount.Text.ToString()), true);
                }
                else if (chkStatus.Checked == false)
                {
                    x = q.CreateQuote(DateTime.Parse(txtDateCreated.Text.ToString()), expDate, float.Parse(txtTotalCost.Text.ToString()), float.Parse(txtDiscount.Text.ToString()), false);
                }
                if (x != 0)
                {
                    lblSuccess.ForeColor = System.Drawing.Color.Green;
                    lblSuccess.Text = "Quote Successfully Created!";
                }
                else
                {
                    lblSuccess.ForeColor = System.Drawing.Color.Red;
                    lblSuccess.Text = "Quote Error!";
                }
                lblSuccess.Visible = true;
            }
        }
    }
}