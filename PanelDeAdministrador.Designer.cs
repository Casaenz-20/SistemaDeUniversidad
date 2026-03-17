namespace SistemaDeUniversidad
{
    partial class PanelDeAdministrador
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
            this.Contenedor = new CuoreUI.Controls.cuiPanel();
            this.RegisCursos = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Location = new System.Drawing.Point(214, -5);
            this.Contenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.OutlineThickness = 1F;
            this.Contenedor.PanelColor = System.Drawing.Color.White;
            this.Contenedor.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Contenedor.Rounding = new System.Windows.Forms.Padding(8);
            this.Contenedor.Size = new System.Drawing.Size(1296, 738);
            this.Contenedor.TabIndex = 3;
            // 
            // RegisCursos
            // 
            this.RegisCursos.AutoSize = true;
            this.RegisCursos.BackColor = System.Drawing.Color.Transparent;
            this.RegisCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisCursos.Location = new System.Drawing.Point(47, 91);
            this.RegisCursos.Name = "RegisCursos";
            this.RegisCursos.Size = new System.Drawing.Size(89, 29);
            this.RegisCursos.TabIndex = 0;
            this.RegisCursos.Text = "Cursos";
            this.RegisCursos.Click += new System.EventHandler(this.RegisCursos_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(-5, 151);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(235, 29);
            this.lblUsuarios.TabIndex = 1;
            this.lblUsuarios.Text = "Administrar Usuarios";
            this.lblUsuarios.Click += new System.EventHandler(this.lblUsuarios_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Panel1.Controls.Add(this.lblUsuarios);
            this.guna2Panel1.Controls.Add(this.RegisCursos);
            this.guna2Panel1.Location = new System.Drawing.Point(-2, -2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(220, 735);
            this.guna2Panel1.TabIndex = 4;
            // 
            // PanelDeAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 730);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Contenedor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PanelDeAdministrador";
            this.Text = "PanelDeAdministrador";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Controls.cuiPanel Contenedor;
        private System.Windows.Forms.Label RegisCursos;
        private System.Windows.Forms.Label lblUsuarios;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}