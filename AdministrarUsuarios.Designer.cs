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
            this.datagridUsuarios.Size = new System.Drawing.Size(901, 261);
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
            this.kryptonLabel1.Size = new System.Drawing.Size(550, 66);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Base De Datos - Usuarios";
            // 
            // AdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.datagridUsuarios);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdministrarUsuarios";
            this.Text = "AdministrarUsuarios";
            this.Load += new System.EventHandler(this.AdministrarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView datagridUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}