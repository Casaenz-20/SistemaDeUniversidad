namespace SistemaDeUniversidad
{
    partial class RegistroCursos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.ContxMenuMatriculas = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datagMatricula = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBuscarMaatriculas = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ContxMenuMatriculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagMatricula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(204, 179);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(326, 31);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Cedula del Estudiante:";
            // 
            // txtCedula
            // 
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.DefaultText = "";
            this.txtCedula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCedula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCedula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCedula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCedula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCedula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCedula.Location = new System.Drawing.Point(656, 161);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PlaceholderText = "";
            this.txtCedula.SelectedText = "";
            this.txtCedula.Size = new System.Drawing.Size(319, 45);
            this.txtCedula.TabIndex = 1;
            // 
            // ContxMenuMatriculas
            // 
            this.ContxMenuMatriculas.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContxMenuMatriculas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.ContxMenuMatriculas.Name = "guna2ContextMenuStrip1";
            this.ContxMenuMatriculas.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ContxMenuMatriculas.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.ContxMenuMatriculas.RenderStyle.ColorTable = null;
            this.ContxMenuMatriculas.RenderStyle.RoundedEdges = true;
            this.ContxMenuMatriculas.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.ContxMenuMatriculas.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ContxMenuMatriculas.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContxMenuMatriculas.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ContxMenuMatriculas.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ContxMenuMatriculas.Size = new System.Drawing.Size(133, 28);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // datagMatricula
            // 
            this.datagMatricula.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.datagMatricula.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagMatricula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagMatricula.ColumnHeadersHeight = 29;
            this.datagMatricula.ContextMenuStrip = this.ContxMenuMatriculas;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagMatricula.DefaultCellStyle = dataGridViewCellStyle6;
            this.datagMatricula.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagMatricula.Location = new System.Drawing.Point(3, 379);
            this.datagMatricula.Name = "datagMatricula";
            this.datagMatricula.RowHeadersVisible = false;
            this.datagMatricula.RowHeadersWidth = 51;
            this.datagMatricula.RowTemplate.Height = 24;
            this.datagMatricula.Size = new System.Drawing.Size(1267, 251);
            this.datagMatricula.TabIndex = 2;
            this.datagMatricula.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagMatricula.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagMatricula.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagMatricula.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagMatricula.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagMatricula.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagMatricula.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagMatricula.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagMatricula.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagMatricula.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagMatricula.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagMatricula.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagMatricula.ThemeStyle.HeaderStyle.Height = 29;
            this.datagMatricula.ThemeStyle.ReadOnly = false;
            this.datagMatricula.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagMatricula.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagMatricula.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagMatricula.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagMatricula.ThemeStyle.RowsStyle.Height = 24;
            this.datagMatricula.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagMatricula.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnBuscarMaatriculas
            // 
            this.btnBuscarMaatriculas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscarMaatriculas.IconColor = System.Drawing.Color.Black;
            this.btnBuscarMaatriculas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarMaatriculas.Location = new System.Drawing.Point(813, 214);
            this.btnBuscarMaatriculas.Name = "btnBuscarMaatriculas";
            this.btnBuscarMaatriculas.Size = new System.Drawing.Size(162, 50);
            this.btnBuscarMaatriculas.TabIndex = 3;
            this.btnBuscarMaatriculas.Text = "Consultar Matriculas";
            this.btnBuscarMaatriculas.UseVisualStyleBackColor = true;
            this.btnBuscarMaatriculas.Click += new System.EventHandler(this.btnBuscarMaatriculas_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistroCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuscarMaatriculas);
            this.Controls.Add(this.datagMatricula);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistroCursos";
            this.Size = new System.Drawing.Size(1495, 690);
            this.Load += new System.EventHandler(this.RegistroCursos_Load);
            this.ContxMenuMatriculas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagMatricula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtCedula;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContxMenuMatriculas;
        private Guna.UI2.WinForms.Guna2DataGridView datagMatricula;
        private FontAwesome.Sharp.IconButton btnBuscarMaatriculas;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
