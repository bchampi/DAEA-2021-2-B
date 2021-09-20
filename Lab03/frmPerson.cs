using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab03
{
    public partial class frmPerson : Form
    {
        SqlConnection conn;
        public frmPerson(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void frmPerson_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM Person";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgbListPerson.DataSource = dt;
                    dgbListPerson.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La conexión está cerrada\n" + ex, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    string firstName = textName.Text;

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SearchPersonByName";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@FirstName";
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Value = firstName;

                    cmd.Parameters.Add(param);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgbListPerson.DataSource = dt;
                    dgbListPerson.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La conexión está cerrada\n" + ex, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
