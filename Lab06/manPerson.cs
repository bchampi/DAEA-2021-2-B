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

namespace Lab06
{
    public partial class manPerson : Form
    {
        SqlConnection conn;
        DataSet ds = new DataSet();
        DataTable tablePerson = new DataTable();
        public manPerson()
        {
            InitializeComponent();
        }

        private void manPerson_Load(object sender, EventArgs e)
        {
            string connection = "Server=DESKTOP-96DA1NJ\\LOCAL; DataBase=School; Integrated Security=true;";
            conn = new SqlConnection(connection);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            adapter.Fill(ds, "Person");

            tablePerson = ds.Tables["Person"];

            dgvListPerson.DataSource = "";
            dgvListPerson.Refresh();
            dgvListPerson.DataSource = tablePerson;
            dgvListPerson.Update();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("InsertPerson", conn);

            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 50, "LastName");
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50, "FirstName");
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

            DataRow row = tablePerson.NewRow();
            row["LastName"] = textLastName.Text;
            row["FirstName"] = textFirstName.Text;
            row["HireDate"] = dtpHire.Text;
            row["EnrollmentDate"] = dtpEnrollment.Text;
            tablePerson.Rows.Add(row);

            adapter.Update(tablePerson);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UpdatePerson", conn);

            cmd.Parameters.Add("@PersonID", SqlDbType.NVarChar).SourceColumn = "PersonID";
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).SourceColumn = "LastName";
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).SourceColumn = "FirstName";
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] row = tablePerson.Select("PersonID = '" + textPersonId.Text + "'");
            row[0]["LastName"] = textLastName.Text;
            row[0]["FirstName"] = textFirstName.Text;
            row[0]["HireDate"] = dtpHire.Text;
            row[0]["EnrollmentDate"] = dtpEnrollment.Text;

            adapter.Update(tablePerson);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DeletePerson", conn);
            cmd.Parameters.Add("@PersonID", SqlDbType.NVarChar).SourceColumn = "PersonID";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] row = tablePerson.Select("PersonID = '" + textPersonId.Text + "'");
            tablePerson.Rows.Remove(row[0]);

            adapter.Update(tablePerson);
        }
    }
}
