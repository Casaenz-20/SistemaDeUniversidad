namespace SistemaDeUniversidad
{
    partial class AdministrarUsuarios
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
            this.datagridUsuarios = new Krypton.Toolkit.KryptonDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtCedula = new Krypton.Toolkit.KryptonTextBox();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.txtUsuario = new Krypton.Toolkit.KryptonTextBox();
            this.cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            this.txtCorreo = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridUsuarios
            // 
            this.datagridUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Usuario,
            this.FechaNacimiento,
            this.Correo,
            this.TipoUsuario});
            this.datagridUsuarios.Location = new System.Drawing.Point(0, 309);
            this.datagridUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagridUsuarios.Name = "datagridUsuarios";
            this.datagridUsuarios.RowHeadersVisible = false;
            this.datagridUsuarios.RowHeadersWidth = 51;
            this.datagridUsuarios.RowTemplate.Height = 24;
            this.datagridUsuarios.Size = new System.Drawing.Size(1048, 261);
            this.datagridUsuarios.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "Cedula";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 8;
            this.Usuario.Name = "Usuario";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaNacimiento.HeaderText = "Fecha De Nacimiento";
            this.FechaNacimiento.MinimumWidth = 8;
            this.FechaNacimiento.Name = "FechaNacimiento";
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correo.HeaderText = "Correo Eletronico";
            this.Correo.MinimumWidth = 8;
            this.Correo.Name = "Correo";
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoUsuario.HeaderText = "Rol Del Usuario";
            this.TipoUsuario.MinimumWidth = 8;
            this.TipoUsuario.Name = "TipoUsuario";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel1.AutoSize = false;
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(200, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(697, 66);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Base De Datos - Usuarios";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(184, 75);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(177, 31);
            this.txtCedula.TabIndex = 2;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Cedula";
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(57, 75);
            this.cuiLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(120, 31);
            this.cuiLabel1.TabIndex = 3;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Usuario";
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel2.Location = new System.Drawing.Point(57, 124);
            this.cuiLabel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(120, 31);
            this.cuiLabel2.TabIndex = 5;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(184, 124);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(177, 31);
            this.txtUsuario.TabIndex = 4;
            // 
            // cuiLabel3
            // 
            this.cuiLabel3.Content = "Fecha:";
            this.cuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel3.Location = new System.Drawing.Point(368, 75);
            this.cuiLabel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiLabel3.Name = "cuiLabel3";
            this.cuiLabel3.Size = new System.Drawing.Size(103, 31);
            this.cuiLabel3.TabIndex = 6;
            this.cuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.Silver;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(464, 70);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(530, 36);
            this.guna2DateTimePicker1.TabIndex = 7;
            this.guna2DateTimePicker1.Value = new System.DateTime(2026, 3, 18, 11, 30, 29, 82);
            // 
            // cuiLabel4
            // 
            this.cuiLabel4.Content = "Correo:";
            this.cuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel4.Location = new System.Drawing.Point(57, 175);
            this.cuiLabel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiLabel4.Name = "cuiLabel4";
            this.cuiLabel4.Size = new System.Drawing.Size(120, 31);
            this.cuiLabel4.TabIndex = 9;
            this.cuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(184, 171);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(287, 31);
            this.txtCorreo.TabIndex = 8;
            // 
            // AdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 562);
            this.Controls.Add(this.cuiLabel4);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.cuiLabel3);
            this.Controls.Add(this.cuiLabel2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cuiLabel1);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.datagridUsuarios);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdministrarUsuarios";
            this.Text = "AdministrarUsuarios";
            this.Load += new System.EventHandler(this.AdministrarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView datagridUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtCedula;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private Krypton.Toolkit.KryptonTextBox txtUsuario;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private Krypton.Toolkit.KryptonTextBox txtCorreo;
    }
}