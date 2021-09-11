using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] credentials = { "admin", "admin"};
            if (credentials[0] == textUser.Text && credentials[1] == textPassword.Text)
            {
                labelError.Visible = true;

                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            } else
            {
                labelError.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // this.Close();
            Application.Exit();
        }
    }
}
