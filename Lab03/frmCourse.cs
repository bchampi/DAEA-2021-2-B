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
    public partial class frmCourse : Form
    {
        SqlConnection conn;
        public frmCourse(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void btnListCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "SELECT * FROM Course";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgbListCourse.DataSource = dt;
                    dgbListCourse.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La conexión está cerrada\n" + ex, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {

        }

        private void textCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    string titleCourse = textCourse.Text;

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SearchCourseByName";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@Title";
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Value = titleCourse;

                    cmd.Parameters.Add(param);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgbListCourse.DataSource = dt;
                    dgbListCourse.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La conexión está cerrada\n" + ex, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
