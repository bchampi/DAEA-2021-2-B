
namespace Lab02
{
    partial class PrincipalMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSisSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProRegistrarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRepVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRepCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRepProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRepProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRepUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRepClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSistema,
            this.menuMantenimiento,
            this.menuProcesos,
            this.menuReportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSistema
            // 
            this.menuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSisSalir});
            this.menuSistema.Name = "menuSistema";
            this.menuSistema.Size = new System.Drawing.Size(75, 26);
            this.menuSistema.Text = "Sistema";
            // 
            // menuSisSalir
            // 
            this.menuSisSalir.Name = "menuSisSalir";
            this.menuSisSalir.Size = new System.Drawing.Size(224, 26);
            this.menuSisSalir.Text = "Salir";
            this.menuSisSalir.Click += new System.EventHandler(this.menuSistemaSalir_Click);
            // 
            // menuMantenimiento
            // 
            this.menuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManUsuarios,
            this.menuManProductos,
            this.menuManCategorias,
            this.menuManProveedores,
            this.menuManClientes});
            this.menuMantenimiento.Name = "menuMantenimiento";
            this.menuMantenimiento.Size = new System.Drawing.Size(124, 24);
            this.menuMantenimiento.Text = "Mantenimiento";
            // 
            // menuManUsuarios
            // 
            this.menuManUsuarios.Name = "menuManUsuarios";
            this.menuManUsuarios.Size = new System.Drawing.Size(224, 26);
            this.menuManUsuarios.Text = "Usuarios";
            this.menuManUsuarios.Click += new System.EventHandler(this.menuManUsuarios_Click);
            // 
            // menuManProductos
            // 
            this.menuManProductos.Name = "menuManProductos";
            this.menuManProductos.Size = new System.Drawing.Size(224, 26);
            this.menuManProductos.Text = "Productos";
            this.menuManProductos.Click += new System.EventHandler(this.menuManProductos_Click);
            // 
            // menuManCategorias
            // 
            this.menuManCategorias.Name = "menuManCategorias";
            this.menuManCategorias.Size = new System.Drawing.Size(224, 26);
            this.menuManCategorias.Text = "Categorias";
            this.menuManCategorias.Click += new System.EventHandler(this.menuManCategorias_Click);
            // 
            // menuManProveedores
            // 
            this.menuManProveedores.Name = "menuManProveedores";
            this.menuManProveedores.Size = new System.Drawing.Size(224, 26);
            this.menuManProveedores.Text = "Proveedores";
            this.menuManProveedores.Click += new System.EventHandler(this.menuManProveedores_Click);
            // 
            // menuManClientes
            // 
            this.menuManClientes.Name = "menuManClientes";
            this.menuManClientes.Size = new System.Drawing.Size(224, 26);
            this.menuManClientes.Text = "Clientes";
            this.menuManClientes.Click += new System.EventHandler(this.menuManClientes_Click);
            // 
            // menuProcesos
            // 
            this.menuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProRegistrarVenta,
            this.menuProRegistrarCompra});
            this.menuProcesos.Name = "menuProcesos";
            this.menuProcesos.Size = new System.Drawing.Size(81, 24);
            this.menuProcesos.Text = "Procesos";
            // 
            // menuProRegistrarVenta
            // 
            this.menuProRegistrarVenta.Name = "menuProRegistrarVenta";
            this.menuProRegistrarVenta.Size = new System.Drawing.Size(208, 26);
            this.menuProRegistrarVenta.Text = "Registrar Venta";
            // 
            // menuProRegistrarCompra
            // 
            this.menuProRegistrarCompra.Name = "menuProRegistrarCompra";
            this.menuProRegistrarCompra.Size = new System.Drawing.Size(208, 26);
            this.menuProRegistrarCompra.Text = "Registrar Compra";
            // 
            // menuReportes
            // 
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRepVentas,
            this.menuRepCompras,
            this.menuRepProductos,
            this.menuRepProveedores,
            this.menuRepUsuarios,
            this.menuRepClientes});
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(82, 24);
            this.menuReportes.Text = "Reportes";
            // 
            // menuRepVentas
            // 
            this.menuRepVentas.Name = "menuRepVentas";
            this.menuRepVentas.Size = new System.Drawing.Size(252, 26);
            this.menuRepVentas.Text = "Reporte de Ventas";
            this.menuRepVentas.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // menuRepCompras
            // 
            this.menuRepCompras.Name = "menuRepCompras";
            this.menuRepCompras.Size = new System.Drawing.Size(252, 26);
            this.menuRepCompras.Text = "Reporte de Compras";
            // 
            // menuRepProductos
            // 
            this.menuRepProductos.Name = "menuRepProductos";
            this.menuRepProductos.Size = new System.Drawing.Size(252, 26);
            this.menuRepProductos.Text = "Inventario de Productos";
            // 
            // menuRepProveedores
            // 
            this.menuRepProveedores.Name = "menuRepProveedores";
            this.menuRepProveedores.Size = new System.Drawing.Size(252, 26);
            this.menuRepProveedores.Text = "Reporte de Proveedores";
            // 
            // menuRepUsuarios
            // 
            this.menuRepUsuarios.Name = "menuRepUsuarios";
            this.menuRepUsuarios.Size = new System.Drawing.Size(252, 26);
            this.menuRepUsuarios.Text = "Reporte de Usuarios";
            // 
            // menuRepClientes
            // 
            this.menuRepClientes.Name = "menuRepClientes";
            this.menuRepClientes.Size = new System.Drawing.Size(252, 26);
            this.menuRepClientes.Text = "Reporte de Clientes";
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.Text = "Panel Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSistema;
        private System.Windows.Forms.ToolStripMenuItem menuMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem menuProcesos;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuSisSalir;
        private System.Windows.Forms.ToolStripMenuItem menuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuManProductos;
        private System.Windows.Forms.ToolStripMenuItem menuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem menuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem menuManClientes;
        private System.Windows.Forms.ToolStripMenuItem menuProRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem menuProRegistrarCompra;
        private System.Windows.Forms.ToolStripMenuItem menuRepVentas;
        private System.Windows.Forms.ToolStripMenuItem menuRepCompras;
        private System.Windows.Forms.ToolStripMenuItem menuRepProductos;
        private System.Windows.Forms.ToolStripMenuItem menuRepProveedores;
        private System.Windows.Forms.ToolStripMenuItem menuRepUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuRepClientes;
    }
}