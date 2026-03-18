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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtCedula = new Krypton.Toolkit.KryptonTextBox();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            this.datePersona = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            this.txtCorreo = new Krypton.Toolkit.KryptonTextBox();
            this.cboxRol = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            this.chkEstado = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.datagridUsuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridUsuarios)).BeginInit();
            this.SuspendLayout();
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
            // datePersona
            // 
            this.datePersona.Checked = true;
            this.datePersona.FillColor = System.Drawing.Color.Silver;
            this.datePersona.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePersona.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePersona.Location = new System.Drawing.Point(464, 70);
            this.datePersona.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePersona.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePersona.Name = "datePersona";
            this.datePersona.Size = new System.Drawing.Size(530, 36);
            this.datePersona.TabIndex = 7;
            this.datePersona.Value = new System.DateTime(2026, 3, 18, 11, 30, 29, 82);
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
            // cboxRol
            // 
            this.cboxRol.BackColor = System.Drawing.Color.Transparent;
            this.cboxRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRol.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxRol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxRol.ItemHeight = 30;
            this.cboxRol.Items.AddRange(new object[] {
            "Administrador",
            "Estudiante"});
            this.cboxRol.Location = new System.Drawing.Point(521, 124);
            this.cboxRol.Name = "cboxRol";
            this.cboxRol.Size = new System.Drawing.Size(271, 36);
            this.cboxRol.TabIndex = 10;
            // 
            // cuiLabel5
            // 
            this.cuiLabel5.Content = "Rol:";
            this.cuiLabel5.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel5.Location = new System.Drawing.Point(449, 134);
            this.cuiLabel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiLabel5.Name = "cuiLabel5";
            this.cuiLabel5.Size = new System.Drawing.Size(74, 21);
            this.cuiLabel5.TabIndex = 11;
            this.cuiLabel5.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // chkEstado
            // 
            this.chkEstado.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkEstado.CheckedState.BorderRadius = 0;
            this.chkEstado.CheckedState.BorderThickness = 0;
            this.chkEstado.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.Location = new System.Drawing.Point(502, 175);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(124, 41);
            this.chkEstado.TabIndex = 12;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkEstado.UncheckedState.BorderRadius = 0;
            this.chkEstado.UncheckedState.BorderThickness = 0;
            this.chkEstado.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(184, 124);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(177, 26);
            this.txtUsuario.TabIndex = 13;
            // 
            // datagridUsuarios
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.datagridUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridUsuarios.ColumnHeadersHeight = 35;
            this.datagridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Usuario,
            this.Correo,
            this.FechaNacimiento,
            this.Rol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.datagridUsuarios.Location = new System.Drawing.Point(3, 281);
            this.datagridUsuarios.Name = "datagridUsuarios";
            this.datagridUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datagridUsuarios.RowHeadersVisible = false;
            this.datagridUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.datagridUsuarios.RowTemplate.Height = 28;
            this.datagridUsuarios.Size = new System.Drawing.Size(1043, 276);
            this.datagridUsuarios.TabIndex = 14;
            this.datagridUsuarios.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.datagridUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.datagridUsuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridUsuarios.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridUsuarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.datagridUsuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.datagridUsuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridUsuarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridUsuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridUsuarios.ThemeStyle.HeaderStyle.Height = 35;
            this.datagridUsuarios.ThemeStyle.ReadOnly = false;
            this.datagridUsuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.datagridUsuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridUsuarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridUsuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridUsuarios.ThemeStyle.RowsStyle.Height = 28;
            this.datagridUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.datagridUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridUsuarios_CellClick);
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
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 8;
            this.Correo.Name = "Correo";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaNacimiento.HeaderText = "Fecha De Nacimiento";
            this.FechaNacimiento.MinimumWidth = 8;
            this.FechaNacimiento.Name = "FechaNacimiento";
            // 
            // Rol
            // 
            this.Rol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 8;
            this.Rol.Name = "Rol";
            // 
            // AdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 562);
            this.Controls.Add(this.datagridUsuarios);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.cuiLabel5);
            this.Controls.Add(this.cboxRol);
            this.Controls.Add(this.cuiLabel4);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.datePersona);
            this.Controls.Add(this.cuiLabel3);
            this.Controls.Add(this.cuiLabel2);
            this.Controls.Add(this.cuiLabel1);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.kryptonLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdministrarUsuarios";
            this.Text = "AdministrarUsuarios";
            this.Load += new System.EventHandler(this.AdministrarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtCedula;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePersona;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private Krypton.Toolkit.KryptonTextBox txtCorreo;
        private Guna.UI2.WinForms.Guna2ComboBox cboxRol;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private Guna.UI2.WinForms.Guna2CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2DataGridView datagridUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
    }
}