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
    public partial class PrincipalMDI : Form
    {
        public PrincipalMDI()
        {
            InitializeComponent();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuSistemaSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuManUsuarios_Click(object sender, EventArgs e)
        {
            manUsuario formUsuario = new manUsuario();
            formUsuario.MdiParent = this;
            formUsuario.Show();
        }

        private void menuManProductos_Click(object sender, EventArgs e)
        {
            manProducto formProducto = new manProducto();
            formProducto.MdiParent = this;
            formProducto.Show();
        }

        private void menuManCategorias_Click(object sender, EventArgs e)
        {
            manCategoria formCategoria = new manCategoria();
            formCategoria.MdiParent = this;
            formCategoria.Show();
        }

        private void menuManProveedores_Click(object sender, EventArgs e)
        {
            manProveedor formProveedor = new manProveedor();
            formProveedor.MdiParent = this;
            formProveedor.Show();
        }

        private void menuManClientes_Click(object sender, EventArgs e)
        {
            manCliente formCliente = new manCliente();
            formCliente.MdiParent = this;
            formCliente.Show();
        }
    }
}
