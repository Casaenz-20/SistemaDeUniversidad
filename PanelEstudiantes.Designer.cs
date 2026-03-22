 
namespace SistemaDeUniversidad
{
    partial class PanelEstudiantes
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
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnMatricular = new FontAwesome.Sharp.IconButton();
            this.btnRegistrMatricula = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.cuiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.iconButton1);
            this.cuiPanel1.Controls.Add(this.btnRegistrMatricula);
            this.cuiPanel1.Controls.Add(this.btnMatricular);
            this.cuiPanel1.Location = new System.Drawing.Point(0, 5);
            this.cuiPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.White;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel1.Size = new System.Drawing.Size(432, 1092);
            this.cuiPanel1.TabIndex = 0;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Location = new System.Drawing.Point(431, 5);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1293, 1088);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // btnMatricular
            // 
            this.btnMatricular.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMatricular.IconColor = System.Drawing.Color.Black;
            this.btnMatricular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMatricular.Location = new System.Drawing.Point(46, 73);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(247, 61);
            this.btnMatricular.TabIndex = 0;
            this.btnMatricular.Text = "Matrcular Cursos";
            this.btnMatricular.UseVisualStyleBackColor = true;
            // 
            // btnRegistrMatricula
            // 
            this.btnRegistrMatricula.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegistrMatricula.IconColor = System.Drawing.Color.Black;
            this.btnRegistrMatricula.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrMatricula.Location = new System.Drawing.Point(46, 167);
            this.btnRegistrMatricula.Name = "btnRegistrMatricula";
            this.btnRegistrMatricula.Size = new System.Drawing.Size(247, 61);
            this.btnRegistrMatricula.TabIndex = 1;
            this.btnRegistrMatricula.Text = "Registro de Matricula";
            this.btnRegistrMatricula.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(12, 464);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(206, 35);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Cerrar Seccion";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // PanelEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1723, 1055);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.cuiPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PanelEstudiantes";
            this.Text = "PanelEstudiantes";
            this.cuiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private FontAwesome.Sharp.IconButton btnRegistrMatricula;
        private FontAwesome.Sharp.IconButton btnMatricular;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}