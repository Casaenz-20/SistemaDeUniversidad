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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelDeAdministrador));
            this.Contenedor = new CuoreUI.Controls.cuiPanel();
            this.GunaPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnVolverLogin = new FontAwesome.Sharp.IconButton();
            this.RegisCursos = new FontAwesome.Sharp.IconButton();
            this.btnUsuariosPanel = new FontAwesome.Sharp.IconButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.GunaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contenedor.Location = new System.Drawing.Point(323, -1);
            this.Contenedor.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.OutlineThickness = 1F;
            this.Contenedor.PanelColor = System.Drawing.Color.White;
            this.Contenedor.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Contenedor.Rounding = new System.Windows.Forms.Padding(8);
            this.Contenedor.Size = new System.Drawing.Size(1313, 735);
            this.Contenedor.TabIndex = 3;
            // 
            // GunaPanel
            // 
            this.GunaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GunaPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.GunaPanel.Controls.Add(this.btnVolverLogin);
            this.GunaPanel.Controls.Add(this.RegisCursos);
            this.GunaPanel.Controls.Add(this.btnUsuariosPanel);
            this.GunaPanel.Location = new System.Drawing.Point(-1, -1);
            this.GunaPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GunaPanel.Name = "GunaPanel";
            this.GunaPanel.Size = new System.Drawing.Size(327, 735);
            this.GunaPanel.TabIndex = 4;
            // 
            // btnVolverLogin
            // 
            this.btnVolverLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnVolverLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolverLogin.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.btnVolverLogin.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolverLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolverLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverLogin.Location = new System.Drawing.Point(0, 479);
            this.btnVolverLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolverLogin.Name = "btnVolverLogin";
            this.btnVolverLogin.Size = new System.Drawing.Size(289, 59);
            this.btnVolverLogin.TabIndex = 4;
            this.btnVolverLogin.Text = "Cerrar Seccion";
            this.btnVolverLogin.UseVisualStyleBackColor = false;
            this.btnVolverLogin.Click += new System.EventHandler(this.btnVolverLogin_Click);
            // 
            // RegisCursos
            // 
            this.RegisCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.RegisCursos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RegisCursos.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.RegisCursos.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.RegisCursos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RegisCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegisCursos.Location = new System.Drawing.Point(14, 79);
            this.RegisCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisCursos.Name = "RegisCursos";
            this.RegisCursos.Size = new System.Drawing.Size(289, 60);
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
            this.btnUsuariosPanel.Location = new System.Drawing.Point(14, 169);
            this.btnUsuariosPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsuariosPanel.Name = "btnUsuariosPanel";
            this.btnUsuariosPanel.Size = new System.Drawing.Size(289, 59);
            this.btnUsuariosPanel.TabIndex = 2;
            this.btnUsuariosPanel.Text = "Usuarios";
            this.btnUsuariosPanel.UseVisualStyleBackColor = false;
            this.btnUsuariosPanel.Click += new System.EventHandler(this.btnUsuariosPanel_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked_1);
            // 
            // PanelDeAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 729);
            this.Controls.Add(this.GunaPanel);
            this.Controls.Add(this.Contenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "PanelDeAdministrador";
            this.Text = "PanelDeAdministrador";
            this.Load += new System.EventHandler(this.PanelDeAdministrador_Load);
            this.Resize += new System.EventHandler(this.PanelDeAdministrador_Resize);
            this.GunaPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Controls.cuiPanel Contenedor;
        private Guna.UI2.WinForms.Guna2Panel GunaPanel;
        private FontAwesome.Sharp.IconButton btnUsuariosPanel;
        private FontAwesome.Sharp.IconButton RegisCursos;
        private FontAwesome.Sharp.IconButton btnVolverLogin;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}