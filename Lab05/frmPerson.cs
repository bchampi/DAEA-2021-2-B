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

namespace Lab05
{
    public partial class frmPerson : Form
    {
        SqlConnection conn;
        public frmPerson()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmPerson_Load(object sender, EventArgs e)
        {
            String str = "Server=DESKTOP-96DA1NJ\\LOCAL; DataBase=School; Integrated Security = true;";
            conn = new SqlConnection(str);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvListPerson.DataSource = dt;
            dgvListPerson.Refresh();
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            string person = "InsertPerson";
            SqlCommand cmd = new SqlCommand(person, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", textFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", textLastName.Text);
            cmd.Parameters.AddWithValue("@HireDate", dtpHire.Value);
            cmd.Parameters.AddWithValue("@EnrollmentDate", dtpEnrollment.Value);

            int code = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show("Se ha registrado a la persona " + textFirstName.Text + " con código " + code + 
                " correctamente", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            string person = "UpdatePerson";
            SqlCommand cmd = new SqlCommand(person, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonID", textPersonId.Text);
            cmd.Parameters.AddWithValue("@FirstName", textFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", textLastName.Text);
            cmd.Parameters.AddWithValue("@HireDate", dtpHire.Value);
            cmd.Parameters.AddWithValue("@EnrollmentDate", dtpEnrollment.Value);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Se ha modificado el registro de la persona " + textFirstName.Text + " correctamente",
                "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string person = "DeletePerson";
            SqlCommand cmd = new SqlCommand(person, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonID", textPersonId.Text);

            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Se ha eliminado el registro de la persona " + textFirstName.Text + " correctamente",
                    "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al eliminar el registro:\n" + ex.ToString(),
                    "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
            btnList.PerformClick();
        }

        private void dgvListPerson_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListPerson.SelectedRows.Count > 0)
            {
                textPersonId.Text = dgvListPerson.SelectedRows[0].Cells[0].Value.ToString();
                textLastName.Text = dgvListPerson.SelectedRows[0].Cells[1].Value.ToString();
                textFirstName.Text = dgvListPerson.SelectedRows[0].Cells[2].Value.ToString();
                dtpHire.Text = dgvListPerson.SelectedRows[0].Cells[3].Value.ToString();
                dtpEnrollment.Text = dgvListPerson.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            string search = "SearchPersonInGeneral";
            SqlCommand cmd = new SqlCommand(search, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            string input = "";
            if (textPersonId.Text != "") input = textPersonId.Text;
            if (textLastName.Text != "") input = textLastName.Text;
            if (textFirstName.Text != "") input = textFirstName.Text;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@input";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = input;

            cmd.Parameters.Add(param);

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvListPerson.DataSource = dt;
            dgvListPerson.Refresh();
            textPersonId.Text = "";
            textLastName.Text = "";
            textFirstName.Text = "";
            conn.Close();
        }
    }
}
