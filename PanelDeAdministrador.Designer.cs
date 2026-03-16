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
            this.cuiPanelGradient1 = new CuoreUI.Controls.cuiPanelGradient();
            this.Contenedor = new CuoreUI.Controls.cuiPanel();
            this.RegisCursos = new System.Windows.Forms.Label();
            this.cuiPanelGradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuiPanelGradient1
            // 
            this.cuiPanelGradient1.Controls.Add(this.RegisCursos);
            this.cuiPanelGradient1.GradientAngle = 0F;
            this.cuiPanelGradient1.Location = new System.Drawing.Point(-1, -8);
            this.cuiPanelGradient1.Name = "cuiPanelGradient1";
            this.cuiPanelGradient1.OutlineThickness = 1F;
            this.cuiPanelGradient1.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cuiPanelGradient1.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cuiPanelGradient1.PanelOutlineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiPanelGradient1.PanelOutlineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiPanelGradient1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanelGradient1.Size = new System.Drawing.Size(217, 738);
            this.cuiPanelGradient1.TabIndex = 2;
            // 
            // Contenedor
            // 
            this.Contenedor.Location = new System.Drawing.Point(214, -5);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.OutlineThickness = 1F;
            this.Contenedor.PanelColor = System.Drawing.Color.White;
            this.Contenedor.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Contenedor.Rounding = new System.Windows.Forms.Padding(8);
            this.Contenedor.Size = new System.Drawing.Size(1296, 738);
            this.Contenedor.TabIndex = 3;
            // 
            // RegisCursos
            // 
            this.RegisCursos.AutoSize = true;
            this.RegisCursos.BackColor = System.Drawing.Color.Transparent;
            this.RegisCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisCursos.Location = new System.Drawing.Point(60, 53);
            this.RegisCursos.Name = "RegisCursos";
            this.RegisCursos.Size = new System.Drawing.Size(89, 29);
            this.RegisCursos.TabIndex = 0;
            this.RegisCursos.Text = "Cursos";
            this.RegisCursos.Click += new System.EventHandler(this.RegisCursos_Click);
            // 
            // PanelDeAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 730);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.cuiPanelGradient1);
            this.Name = "PanelDeAdministrador";
            this.Text = "PanelDeAdministrador";
            this.cuiPanelGradient1.ResumeLayout(false);
            this.cuiPanelGradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanelGradient cuiPanelGradient1;
        private CuoreUI.Controls.cuiPanel Contenedor;
        private System.Windows.Forms.Label RegisCursos;
    }
}