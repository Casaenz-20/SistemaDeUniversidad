namespace SistemaDeUniversidad
{
    partial class ModificarUser
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
            this.mskFechaPersona = new System.Windows.Forms.MaskedTextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.chkEstado = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            this.cboxRol = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            this.txtCorreo = new Krypton.Toolkit.KryptonTextBox();
            this.cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.txtCedula = new Krypton.Toolkit.KryptonTextBox();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.btnGuardarCambios = new CuoreUI.Controls.cuiButton();
            this.cuiLabel6 = new CuoreUI.Controls.cuiLabel();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mskFechaPersona
            // 
            this.mskFechaPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFechaPersona.Location = new System.Drawing.Point(505, 8);
            this.mskFechaPersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskFechaPersona.Name = "mskFechaPersona";
            this.mskFechaPersona.Size = new System.Drawing.Size(208, 35);
            this.mskFechaPersona.TabIndex = 35;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(505, 49);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(263, 32);
            this.txtUsuario.TabIndex = 34;
            // 
            // chkEstado
            // 
            this.chkEstado.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkEstado.CheckedState.BorderRadius = 0;
            this.chkEstado.CheckedState.BorderThickness = 0;
            this.chkEstado.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkEstado.Location = new System.Drawing.Point(44, 173);
            this.chkEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(83, 31);
            this.chkEstado.TabIndex = 33;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkEstado.UncheckedState.BorderRadius = 0;
            this.chkEstado.UncheckedState.BorderThickness = 0;
            this.chkEstado.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // cuiLabel5
            // 
            this.cuiLabel5.Content = "Rol:";
            this.cuiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel5.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel5.Location = new System.Drawing.Point(16, 112);
            this.cuiLabel5.Name = "cuiLabel5";
            this.cuiLabel5.Size = new System.Drawing.Size(77, 27);
            this.cuiLabel5.TabIndex = 32;
            this.cuiLabel5.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cboxRol
            // 
            this.cboxRol.BackColor = System.Drawing.Color.Transparent;
            this.cboxRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRol.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxRol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxRol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxRol.ItemHeight = 30;
            this.cboxRol.Items.AddRange(new object[] {
            "Administrador",
            "Estudiante"});
            this.cboxRol.Location = new System.Drawing.Point(116, 112);
            this.cboxRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxRol.Name = "cboxRol";
            this.cboxRol.Size = new System.Drawing.Size(167, 36);
            this.cboxRol.TabIndex = 31;
            // 
            // cuiLabel4
            // 
            this.cuiLabel4.Content = "Correo:";
            this.cuiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel4.Location = new System.Drawing.Point(9, 60);
            this.cuiLabel4.Name = "cuiLabel4";
            this.cuiLabel4.Size = new System.Drawing.Size(84, 39);
            this.cuiLabel4.TabIndex = 30;
            this.cuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(116, 60);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(208, 30);
            this.txtCorreo.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.TabIndex = 29;
            // 
            // cuiLabel3
            // 
            this.cuiLabel3.Content = "Fecha:";
            this.cuiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel3.Location = new System.Drawing.Point(361, 9);
            this.cuiLabel3.Name = "cuiLabel3";
            this.cuiLabel3.Size = new System.Drawing.Size(105, 34);
            this.cuiLabel3.TabIndex = 28;
            this.cuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Cedula";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(-11, 16);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(103, 37);
            this.cuiLabel1.TabIndex = 27;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(116, 16);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(111, 31);
            this.txtCedula.TabIndex = 26;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Usuario:";
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel2.Location = new System.Drawing.Point(377, 49);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(109, 34);
            this.cuiLabel2.TabIndex = 36;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.CheckButton = false;
            this.btnGuardarCambios.Checked = false;
            this.btnGuardarCambios.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnGuardarCambios.CheckedForeColor = System.Drawing.Color.Gray;
            this.btnGuardarCambios.CheckedImageTint = System.Drawing.Color.DimGray;
            this.btnGuardarCambios.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnGuardarCambios.Content = "Guardar Camabios";
            this.btnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCambios.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarCambios.HoverBackground = System.Drawing.Color.White;
            this.btnGuardarCambios.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnGuardarCambios.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnGuardarCambios.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardarCambios.Image = null;
            this.btnGuardarCambios.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnGuardarCambios.Location = new System.Drawing.Point(327, 173);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnGuardarCambios.NormalForeColor = System.Drawing.Color.Black;
            this.btnGuardarCambios.NormalImageTint = System.Drawing.Color.Black;
            this.btnGuardarCambios.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardarCambios.OutlineThickness = 1F;
            this.btnGuardarCambios.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnGuardarCambios.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarCambios.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnGuardarCambios.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnGuardarCambios.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardarCambios.Rounding = new System.Windows.Forms.Padding(8);
            this.btnGuardarCambios.Size = new System.Drawing.Size(226, 46);
            this.btnGuardarCambios.TabIndex = 37;
            this.btnGuardarCambios.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnGuardarCambios.TextPadding = -1;
            this.btnGuardarCambios.TextSpacing = 2;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // cuiLabel6
            // 
            this.cuiLabel6.Content = "Contraseña:";
            this.cuiLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel6.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel6.Location = new System.Drawing.Point(377, 112);
            this.cuiLabel6.Name = "cuiLabel6";
            this.cuiLabel6.Size = new System.Drawing.Size(147, 34);
            this.cuiLabel6.TabIndex = 38;
            this.cuiLabel6.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(543, 107);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(263, 32);
            this.txtContrasena.TabIndex = 39;
            // 
            // ModificarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1098, 226);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.cuiLabel6);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.cuiLabel2);
            this.Controls.Add(this.mskFechaPersona);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.cuiLabel5);
            this.Controls.Add(this.cboxRol);
            this.Controls.Add(this.cuiLabel4);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.cuiLabel3);
            this.Controls.Add(this.cuiLabel1);
            this.Controls.Add(this.txtCedula);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModificarUser";
            this.Text = "ModificarUser";
            this.Load += new System.EventHandler(this.ModificarUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskFechaPersona;
        private System.Windows.Forms.TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2CheckBox chkEstado;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cboxRol;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private Krypton.Toolkit.KryptonTextBox txtCorreo;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private Krypton.Toolkit.KryptonTextBox txtCedula;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiButton btnGuardarCambios;
        private CuoreUI.Controls.cuiLabel cuiLabel6;
        private System.Windows.Forms.TextBox txtContrasena;
    }
}