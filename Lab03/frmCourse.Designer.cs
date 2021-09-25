
namespace Lab03
{
    partial class frmCourse
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
            this.dgbListCourse = new System.Windows.Forms.DataGridView();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.textCourse = new System.Windows.Forms.TextBox();
            this.btnListCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbListCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbListCourse
            // 
            this.dgbListCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbListCourse.Location = new System.Drawing.Point(19, 64);
            this.dgbListCourse.Margin = new System.Windows.Forms.Padding(10);
            this.dgbListCourse.Name = "dgbListCourse";
            this.dgbListCourse.RowHeadersWidth = 51;
            this.dgbListCourse.RowTemplate.Height = 24;
            this.dgbListCourse.Size = new System.Drawing.Size(594, 470);
            this.dgbListCourse.TabIndex = 7;
            // 
            // btnSearchCourse
            // 
            this.btnSearchCourse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearchCourse.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCourse.Location = new System.Drawing.Point(494, 19);
            this.btnSearchCourse.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.btnSearchCourse.Name = "btnSearchCourse";
            this.btnSearchCourse.Size = new System.Drawing.Size(119, 32);
            this.btnSearchCourse.TabIndex = 6;
            this.btnSearchCourse.Text = "Buscar";
            this.btnSearchCourse.UseVisualStyleBackColor = true;
            this.btnSearchCourse.Click += new System.EventHandler(this.btnSearchCourse_Click);
            // 
            // textCourse
            // 
            this.textCourse.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCourse.Location = new System.Drawing.Point(220, 20);
            this.textCourse.Name = "textCourse";
            this.textCourse.Size = new System.Drawing.Size(268, 30);
            this.textCourse.TabIndex = 5;
            this.textCourse.TextChanged += new System.EventHandler(this.textCourse_TextChanged);
            // 
            // btnListCourse
            // 
            this.btnListCourse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnListCourse.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCourse.Location = new System.Drawing.Point(19, 19);
            this.btnListCourse.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.btnListCourse.Name = "btnListCourse";
            this.btnListCourse.Size = new System.Drawing.Size(119, 32);
            this.btnListCourse.TabIndex = 4;
            this.btnListCourse.Text = "Listar";
            this.btnListCourse.UseVisualStyleBackColor = true;
            this.btnListCourse.Click += new System.EventHandler(this.btnListCourse_Click);
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 553);
            this.Controls.Add(this.dgbListCourse);
            this.Controls.Add(this.btnSearchCourse);
            this.Controls.Add(this.textCourse);
            this.Controls.Add(this.btnListCourse);
            this.Name = "frmCourse";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.frmCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbListCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbListCourse;
        private System.Windows.Forms.Button btnSearchCourse;
        private System.Windows.Forms.TextBox textCourse;
        private System.Windows.Forms.Button btnListCourse;
    }
}