
namespace Lab03
{
    partial class dbConn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textServer = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDB = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.checkAuthentication = new System.Windows.Forms.CheckBox();
            this.btnState = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // textServer
            // 
            this.textServer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textServer.Location = new System.Drawing.Point(29, 49);
            this.textServer.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(239, 30);
            this.textServer.TabIndex = 1;
            this.textServer.Text = "DESKTOP-96DA1NJ\\LOCAL";
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(29, 212);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 44);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(310, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(25, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Base de Datos";
            // 
            // textUser
            // 
            this.textUser.Enabled = false;
            this.textUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.Location = new System.Drawing.Point(314, 49);
            this.textUser.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(239, 30);
            this.textUser.TabIndex = 7;
            this.textUser.Text = "root";
            this.textUser.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(310, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contraseña";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textDB
            // 
            this.textDB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDB.Location = new System.Drawing.Point(29, 123);
            this.textDB.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.textDB.Name = "textDB";
            this.textDB.Size = new System.Drawing.Size(239, 30);
            this.textDB.TabIndex = 9;
            this.textDB.Text = "School";
            // 
            // textPassword
            // 
            this.textPassword.Enabled = false;
            this.textPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(314, 123);
            this.textPassword.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(239, 30);
            this.textPassword.TabIndex = 11;
            this.textPassword.Text = "root";
            // 
            // checkAuthentication
            // 
            this.checkAuthentication.AutoSize = true;
            this.checkAuthentication.Checked = true;
            this.checkAuthentication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAuthentication.Location = new System.Drawing.Point(29, 171);
            this.checkAuthentication.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.checkAuthentication.Name = "checkAuthentication";
            this.checkAuthentication.Size = new System.Drawing.Size(179, 21);
            this.checkAuthentication.TabIndex = 12;
            this.checkAuthentication.Text = "Autenticación integrada";
            this.checkAuthentication.UseVisualStyleBackColor = true;
            this.checkAuthentication.CheckedChanged += new System.EventHandler(this.checkAuthentication_CheckedChanged);
            // 
            // btnState
            // 
            this.btnState.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnState.Location = new System.Drawing.Point(154, 212);
            this.btnState.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(114, 44);
            this.btnState.TabIndex = 13;
            this.btnState.Text = "Estado";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDisconnect.Location = new System.Drawing.Point(29, 267);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(239, 44);
            this.btnDisconnect.TabIndex = 14;
            this.btnDisconnect.Text = "Desconectar";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.BackColor = System.Drawing.SystemColors.Control;
            this.btnPerson.Enabled = false;
            this.btnPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerson.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerson.ForeColor = System.Drawing.Color.Orange;
            this.btnPerson.Location = new System.Drawing.Point(29, 329);
            this.btnPerson.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(239, 44);
            this.btnPerson.TabIndex = 15;
            this.btnPerson.Text = "Personas";
            this.btnPerson.UseVisualStyleBackColor = false;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.Control;
            this.btnSignIn.Enabled = false;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSignIn.Location = new System.Drawing.Point(314, 212);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(239, 99);
            this.btnSignIn.TabIndex = 16;
            this.btnSignIn.Text = "Login";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.BackColor = System.Drawing.SystemColors.Control;
            this.btnCourse.Enabled = false;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCourse.Location = new System.Drawing.Point(314, 329);
            this.btnCourse.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(239, 44);
            this.btnCourse.TabIndex = 17;
            this.btnCourse.Text = "Cursos";
            this.btnCourse.UseVisualStyleBackColor = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // dbConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(582, 397);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnPerson);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.checkAuthentication);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textDB);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.textServer);
            this.Controls.Add(this.label1);
            this.Name = "dbConn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexión a un origen de Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textServer;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDB;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.CheckBox checkAuthentication;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnCourse;
    }
}

