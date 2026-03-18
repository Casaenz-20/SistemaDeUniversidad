using System.Drawing;

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
            this.btnUsuariosPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.btnUsuariosPanel.SuspendLayout();
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
            this.RegisCursos.BackColor = System.Drawing.Color.Transparent;
            this.RegisCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisCursos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RegisCursos.Image = global::SistemaDeUniversidad.Properties.Resources.usuario;
            this.RegisCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegisCursos.Location = new System.Drawing.Point(81, 91);
            this.RegisCursos.Name = "RegisCursos";
            this.RegisCursos.Size = new System.Drawing.Size(122, 29);
            this.RegisCursos.TabIndex = 0;
            this.RegisCursos.Text = "Cursos";
            this.RegisCursos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.RegisCursos.Click += new System.EventHandler(this.RegisCursos_Click);
            // 
            // btnUsuariosPanel
            // 
            this.btnUsuariosPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnUsuariosPanel.Controls.Add(this.iconButton1);
            this.btnUsuariosPanel.Controls.Add(this.lblUsuarios);
            this.btnUsuariosPanel.Controls.Add(this.RegisCursos);
            this.btnUsuariosPanel.Location = new System.Drawing.Point(-2, -2);
            this.btnUsuariosPanel.Name = "btnUsuariosPanel";
            this.btnUsuariosPanel.Size = new System.Drawing.Size(327, 735);
            this.btnUsuariosPanel.TabIndex = 4;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(14, 170);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(290, 48);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Usuarios";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(86, 147);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(156, 20);
            this.lblUsuarios.TabIndex = 1;
            this.lblUsuarios.Text = "Administrar Usuarios";
            // 
            // PanelDeAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 730);
            this.Controls.Add(this.btnUsuariosPanel);
            this.Controls.Add(this.Contenedor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PanelDeAdministrador";
            this.Text = "PanelDeAdministrador";
            this.btnUsuariosPanel.ResumeLayout(false);
            this.btnUsuariosPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Controls.cuiPanel Contenedor;
        private System.Windows.Forms.Label RegisCursos;
        private Guna.UI2.WinForms.Guna2Panel btnUsuariosPanel;
        private System.Windows.Forms.Label lblUsuarios;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}