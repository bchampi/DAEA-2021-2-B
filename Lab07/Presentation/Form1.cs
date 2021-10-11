using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        DataTable tablePerson = new DataTable();
        BusinessPerson bp = new BusinessPerson();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tablePerson = bp.GetAll();

            dgvData.DataSource = tablePerson;
            dgvData.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BusinessPerson bp = new BusinessPerson();
            tablePerson = bp.SearchPerson(textInput.Text);
            dgvData.DataSource = tablePerson;
            dgvData.Refresh();
        }
    }
}
