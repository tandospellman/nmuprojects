using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AutoClinicWeb
{
    public partial class ViewMechanics : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["dotEXE_CSMS"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);
        Mechanic mechanic = new Mechanic();

        protected void Page_Load(object sender, EventArgs e)
        {
            dgvActiveMechanics.DataSource = mechanic.GetActiveMechanics();
            dgvActiveMechanics.DataBind();
        }

        protected void dgvActiveMechanics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}