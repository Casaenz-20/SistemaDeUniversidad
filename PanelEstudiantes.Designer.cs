 
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
            this.CambiarContra = new FontAwesome.Sharp.IconButton();
            this.btnVerCursos = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnRegistrMatricula = new FontAwesome.Sharp.IconButton();
            this.btnMatricular = new FontAwesome.Sharp.IconButton();
            this.ContenedorEstudiantes = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.cuiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel1.Controls.Add(this.CambiarContra);
            this.cuiPanel1.Controls.Add(this.btnVerCursos);
            this.cuiPanel1.Controls.Add(this.iconButton1);
            this.cuiPanel1.Controls.Add(this.btnRegistrMatricula);
            this.cuiPanel1.Controls.Add(this.btnMatricular);
            this.cuiPanel1.Location = new System.Drawing.Point(0, 6);
            this.cuiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.White;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel1.Size = new System.Drawing.Size(486, 1365);
            this.cuiPanel1.TabIndex = 0;
            // 
            // CambiarContra
            // 
            this.CambiarContra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.CambiarContra.IconColor = System.Drawing.Color.Black;
            this.CambiarContra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CambiarContra.Location = new System.Drawing.Point(52, 286);
            this.CambiarContra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CambiarContra.Name = "CambiarContra";
            this.CambiarContra.Size = new System.Drawing.Size(278, 76);
            this.CambiarContra.TabIndex = 4;
            this.CambiarContra.Text = "Cambiar Contraseña";
            this.CambiarContra.UseVisualStyleBackColor = true;
            this.CambiarContra.Click += new System.EventHandler(this.CambiarContra_Click);
            // 
            // btnVerCursos
            // 
            this.btnVerCursos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerCursos.IconColor = System.Drawing.Color.Black;
            this.btnVerCursos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerCursos.Location = new System.Drawing.Point(52, 390);
            this.btnVerCursos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerCursos.Name = "btnVerCursos";
            this.btnVerCursos.Size = new System.Drawing.Size(278, 76);
            this.btnVerCursos.TabIndex = 3;
            this.btnVerCursos.Text = "Ver Cursos Disponibles";
            this.btnVerCursos.UseVisualStyleBackColor = true;
            this.btnVerCursos.Click += new System.EventHandler(this.btnVerCursos_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(14, 580);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(291, 44);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Cerrar Seccion";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnRegistrMatricula
            // 
            this.btnRegistrMatricula.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegistrMatricula.IconColor = System.Drawing.Color.Black;
            this.btnRegistrMatricula.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrMatricula.Location = new System.Drawing.Point(52, 181);
            this.btnRegistrMatricula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrMatricula.Name = "btnRegistrMatricula";
            this.btnRegistrMatricula.Size = new System.Drawing.Size(278, 76);
            this.btnRegistrMatricula.TabIndex = 1;
            this.btnRegistrMatricula.Text = "Registro de Matricula";
            this.btnRegistrMatricula.UseVisualStyleBackColor = true;
            // 
            // btnMatricular
            // 
            this.btnMatricular.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMatricular.IconColor = System.Drawing.Color.Black;
            this.btnMatricular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMatricular.Location = new System.Drawing.Point(52, 56);
            this.btnMatricular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(278, 76);
            this.btnMatricular.TabIndex = 0;
            this.btnMatricular.Text = "Matrcular Cursos";
            this.btnMatricular.UseVisualStyleBackColor = true;
            // 
            // ContenedorEstudiantes
            // 
            this.ContenedorEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContenedorEstudiantes.Location = new System.Drawing.Point(485, 6);
            this.ContenedorEstudiantes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContenedorEstudiantes.Name = "ContenedorEstudiantes";
            this.ContenedorEstudiantes.Size = new System.Drawing.Size(1455, 1360);
            this.ContenedorEstudiantes.TabIndex = 1;
            // 
            // PanelEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1938, 1319);
            this.Controls.Add(this.ContenedorEstudiantes);
            this.Controls.Add(this.cuiPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PanelEstudiantes";
            this.Text = "PanelEstudiantes";
            this.cuiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel ContenedorEstudiantes;
        private FontAwesome.Sharp.IconButton btnRegistrMatricula;
        private FontAwesome.Sharp.IconButton btnMatricular;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton CambiarContra;
        private FontAwesome.Sharp.IconButton btnVerCursos;
    }
}