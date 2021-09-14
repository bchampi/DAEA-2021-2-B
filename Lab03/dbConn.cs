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
    public partial class dbConn : Form
    {
        SqlConnection conn;
        public dbConn()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            String server = textServer.Text;
            String db = textDB.Text;
            String user = textUser.Text;
            String password= textPassword.Text;
            
            String str = "Server=" + server + ";Database=" + db + ";";

            if (checkAuthentication.Checked)
                str += "Integrated security=true";
            else
                str += "User Id=" + user + ";Password=" + password + ";";

            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado satisfactoriamente");
                btnDisconnect.Enabled = true;
                btnSignIn.Enabled = true;
                btnPerson.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar al servidor:\n" + ex.ToString());
            }
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    MessageBox.Show("Estado del servidor: " + conn.State + "\nVersión del servidor: " + conn.ServerVersion +
                        "\nBase de datos: " + conn.Database);
                else
                    MessageBox.Show("Estado del servidor: " + conn.State);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible determinar el estado del servidor:\n" + ex.ToString());
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    MessageBox.Show("Conexión cerrada satisfactoriamente");
                    btnDisconnect.Enabled = false;
                    btnSignIn.Enabled = false;
                    btnPerson.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cerrar la conexión:\n" + ex.ToString());
            }
        }

        private void checkAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAuthentication.Checked)
            {
                textUser.Enabled = false;
                textPassword.Enabled = false;
            }
            else
            {
                textUser.Enabled = true;
                textPassword.Enabled = true;
            }
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            frmPerson formPerson = new frmPerson(conn);
            formPerson.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin(conn);
            formLogin.Show();
        }
    }
}
