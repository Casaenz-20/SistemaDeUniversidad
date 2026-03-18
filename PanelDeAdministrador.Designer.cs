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
            this.GunaPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.RegisCursos = new FontAwesome.Sharp.IconButton();
            this.btnUsuariosPanel = new FontAwesome.Sharp.IconButton();
            this.GunaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contenedor.Location = new System.Drawing.Point(322, -2);
            this.Contenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.OutlineThickness = 1F;
            this.Contenedor.PanelColor = System.Drawing.Color.White;
            this.Contenedor.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Contenedor.Rounding = new System.Windows.Forms.Padding(8);
            this.Contenedor.Size = new System.Drawing.Size(1312, 735);
            this.Contenedor.TabIndex = 3;
            // 
            // GunaPanel
            // 
            this.GunaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GunaPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.GunaPanel.Controls.Add(this.RegisCursos);
            this.GunaPanel.Controls.Add(this.btnUsuariosPanel);
            this.GunaPanel.Location = new System.Drawing.Point(-2, -2);
            this.GunaPanel.Name = "GunaPanel";
            this.GunaPanel.Size = new System.Drawing.Size(327, 735);
            this.GunaPanel.TabIndex = 4;
            // 
            // RegisCursos
            // 
            this.RegisCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.RegisCursos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RegisCursos.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.RegisCursos.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.RegisCursos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RegisCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegisCursos.Location = new System.Drawing.Point(14, 78);
            this.RegisCursos.Name = "RegisCursos";
            this.RegisCursos.Size = new System.Drawing.Size(290, 60);
            this.RegisCursos.TabIndex = 3;
            this.RegisCursos.Text = "Cursos";
            this.RegisCursos.UseVisualStyleBackColor = false;
            this.RegisCursos.Click += new System.EventHandler(this.RegisCursos_Click_1);
            // 
            // btnUsuariosPanel
            // 
            this.btnUsuariosPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnUsuariosPanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuariosPanel.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            this.btnUsuariosPanel.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuariosPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuariosPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuariosPanel.Location = new System.Drawing.Point(14, 170);
            this.btnUsuariosPanel.Name = "btnUsuariosPanel";
            this.btnUsuariosPanel.Size = new System.Drawing.Size(290, 58);
            this.btnUsuariosPanel.TabIndex = 2;
            this.btnUsuariosPanel.Text = "Usuarios";
            this.btnUsuariosPanel.UseVisualStyleBackColor = false;
            this.btnUsuariosPanel.Click += new System.EventHandler(this.btnUsuariosPanel_Click);
            // 
            // PanelDeAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 730);
            this.Controls.Add(this.GunaPanel);
            this.Controls.Add(this.Contenedor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PanelDeAdministrador";
            this.Text = "PanelDeAdministrador";
            this.GunaPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Controls.cuiPanel Contenedor;
        private Guna.UI2.WinForms.Guna2Panel GunaPanel;
        private FontAwesome.Sharp.IconButton btnUsuariosPanel;
        private FontAwesome.Sharp.IconButton RegisCursos;
    }
}