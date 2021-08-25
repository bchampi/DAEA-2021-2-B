using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string code = lblCode.Text;
            string name = txtName.Text;
            string dni = txtDni.Text;
            string lastName = txtLastName.Text;
            string direction = txtDirection.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string dateBirth = txtDateBirth.Text;
            string department = cbxDepartment.Text;

            dgvUsers.Rows.Add(code, dni, name, lastName, direction, phone, email, dateBirth, department);
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUsers.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
