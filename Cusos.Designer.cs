namespace SistemaDeUniversidad
{
    partial class Cusos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCodigoCurso = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombreCurso = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboResinto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resinto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonasMatri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarCurso = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.Resinto,
            this.PersonasMatri});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(3, 291);
            this.kryptonDataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersVisible = false;
            this.kryptonDataGridView1.RowHeadersWidth = 62;
            this.kryptonDataGridView1.RowTemplate.Height = 28;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1172, 380);
            this.kryptonDataGridView1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.AutoSize = false;
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(504, 4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(210, 35);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Registar Cursos";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(179, 114);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(67, 24);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Codigo";
            // 
            // txtCodigoCurso
            // 
            this.txtCodigoCurso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoCurso.DefaultText = "";
            this.txtCodigoCurso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoCurso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoCurso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoCurso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoCurso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoCurso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigoCurso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoCurso.Location = new System.Drawing.Point(253, 114);
            this.txtCodigoCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoCurso.Name = "txtCodigoCurso";
            this.txtCodigoCurso.PlaceholderText = "";
            this.txtCodigoCurso.SelectedText = "";
            this.txtCodigoCurso.Size = new System.Drawing.Size(229, 23);
            this.txtCodigoCurso.TabIndex = 3;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCurso.DefaultText = "";
            this.txtNombreCurso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreCurso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreCurso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreCurso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreCurso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreCurso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreCurso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreCurso.Location = new System.Drawing.Point(670, 114);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.PlaceholderText = "";
            this.txtNombreCurso.SelectedText = "";
            this.txtNombreCurso.Size = new System.Drawing.Size(229, 23);
            this.txtNombreCurso.TabIndex = 5;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(521, 115);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(143, 24);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "Nombre del Curso";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.DefaultText = "";
            this.txtPrecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.Location = new System.Drawing.Point(253, 160);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PlaceholderText = "";
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.Size = new System.Drawing.Size(229, 23);
            this.txtPrecio.TabIndex = 7;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(179, 160);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(67, 24);
            this.guna2HtmlLabel3.TabIndex = 6;
            this.guna2HtmlLabel3.Text = "Precio";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(540, 160);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(67, 24);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "Recinto";
            // 
            // cboResinto
            // 
            this.cboResinto.BackColor = System.Drawing.Color.Transparent;
            this.cboResinto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboResinto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResinto.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboResinto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboResinto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboResinto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboResinto.ItemHeight = 30;
            this.cboResinto.Items.AddRange(new object[] {
            "San José",
            "Alajuela",
            "Cartago",
            "Heredia",
            "Guanacaste",
            "Puntarenas",
            "Limón"});
            this.cboResinto.Location = new System.Drawing.Point(655, 147);
            this.cboResinto.Name = "cboResinto";
            this.cboResinto.Size = new System.Drawing.Size(244, 36);
            this.cboResinto.TabIndex = 9;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            // 
            // Resinto
            // 
            this.Resinto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Resinto.HeaderText = "Resinto";
            this.Resinto.MinimumWidth = 6;
            this.Resinto.Name = "Resinto";
            // 
            // PersonasMatri
            // 
            this.PersonasMatri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PersonasMatri.HeaderText = "Personas Matriculadas";
            this.PersonasMatri.MinimumWidth = 8;
            this.PersonasMatri.Name = "PersonasMatri";
            // 
            // btnGuardarCurso
            // 
            this.btnGuardarCurso.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCurso.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarCurso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardarCurso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardarCurso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardarCurso.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCurso.Location = new System.Drawing.Point(444, 202);
            this.btnGuardarCurso.Name = "btnGuardarCurso";
            this.btnGuardarCurso.Size = new System.Drawing.Size(180, 45);
            this.btnGuardarCurso.TabIndex = 10;
            this.btnGuardarCurso.Text = "Guardar Curso";
            this.btnGuardarCurso.Click += new System.EventHandler(this.btnGuardarCurso_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Cusos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGuardarCurso);
            this.Controls.Add(this.cboResinto);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtCodigoCurso);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cusos";
            this.Size = new System.Drawing.Size(1178, 674);
            this.Load += new System.EventHandler(this.Cusos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoCurso;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreCurso;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cboResinto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resinto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonasMatri;
        private Guna.UI2.WinForms.Guna2Button btnGuardarCurso;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
