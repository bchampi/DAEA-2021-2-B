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
    public partial class frmLogin : Form
    {
        SqlConnection conn;
        public frmLogin(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "Server=DESKTOP-96DA1NJ\\LOCAL; DataBase=db_lab03; Integrated Security=true";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT user_name, user_password FROM tbl_user WHERE user_name = '" +
                    textUser.Text + "' and user_password = '" + textPassword.Text + "';", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    labelError.Visible = false;
                    MessageBox.Show("Bienvenido " + textUser.Text, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }

                else
                {
                    labelError.Visible = true;
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión\n" + ex);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
