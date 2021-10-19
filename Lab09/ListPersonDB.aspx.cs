using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab09
{
    public partial class ListPersonDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["connDB"].ConnectionString))
                {
                    string sql = "SELECT * FROM Person";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Connection = conn;
                    conn.Open();

                    dgvPerson.DataSource = cmd.ExecuteReader();
                    dgvPerson.DataBind();
                }
            }
        }
    }
}