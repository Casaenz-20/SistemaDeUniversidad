namespace SistemaDeUniversidad
{
    partial class RecuperarContra
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
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonRichTextBox1 = new Krypton.Toolkit.KryptonRichTextBox();
            this.txtCorreoRecuperar = new Krypton.Toolkit.KryptonTextBox();
            this.btnRecuperar = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(237, 10);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(269, 35);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Recuperar Contraseña";
            // 
            // kryptonRichTextBox1
            // 
            this.kryptonRichTextBox1.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelAlternate;
            this.kryptonRichTextBox1.Location = new System.Drawing.Point(2, 48);
            this.kryptonRichTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            this.kryptonRichTextBox1.ReadOnly = true;
            this.kryptonRichTextBox1.Size = new System.Drawing.Size(836, 63);
            this.kryptonRichTextBox1.TabIndex = 1;
            this.kryptonRichTextBox1.Text = "Ingrese un correo eletronico que este vinculado a una cuenta registrada en el sis" +
    "tema.Se le enviara su contraseña\npor medio de correo eletronico ingresado\n\n";
            // 
            // txtCorreoRecuperar
            // 
            this.txtCorreoRecuperar.Location = new System.Drawing.Point(158, 152);
            this.txtCorreoRecuperar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreoRecuperar.Name = "txtCorreoRecuperar";
            this.txtCorreoRecuperar.Size = new System.Drawing.Size(452, 27);
            this.txtCorreoRecuperar.TabIndex = 2;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(213, 182);
            this.btnRecuperar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(342, 25);
            this.btnRecuperar.TabIndex = 3;
            this.btnRecuperar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRecuperar.Values.Text = "Recuperar";
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // RecuperarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 360);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.txtCorreoRecuperar);
            this.Controls.Add(this.kryptonRichTextBox1);
            this.Controls.Add(this.kryptonLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RecuperarContra";
            this.Text = "RecuperarContra";
            this.Load += new System.EventHandler(this.RecuperarContra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox1;
        private Krypton.Toolkit.KryptonTextBox txtCorreoRecuperar;
        private Krypton.Toolkit.KryptonButton btnRecuperar;
    }
}