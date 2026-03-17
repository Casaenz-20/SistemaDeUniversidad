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
            this.RegisCursos = new System.Windows.Forms.Label();
            this.Contenedor = new CuoreUI.Controls.cuiPanel();
            this.cuiPanelGradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuiPanelGradient1
            // 
            this.cuiPanelGradient1.Controls.Add(this.RegisCursos);
            this.cuiPanelGradient1.GradientAngle = 0F;
            this.cuiPanelGradient1.Location = new System.Drawing.Point(-1, -6);
            this.cuiPanelGradient1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cuiPanelGradient1.Name = "cuiPanelGradient1";
            this.cuiPanelGradient1.OutlineThickness = 1F;
            this.cuiPanelGradient1.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cuiPanelGradient1.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cuiPanelGradient1.PanelOutlineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiPanelGradient1.PanelOutlineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiPanelGradient1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanelGradient1.Size = new System.Drawing.Size(193, 590);
            this.cuiPanelGradient1.TabIndex = 2;
            // 
            // RegisCursos
            // 
            this.RegisCursos.AutoSize = true;
            this.RegisCursos.BackColor = System.Drawing.Color.Transparent;
            this.RegisCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisCursos.Location = new System.Drawing.Point(53, 42);
            this.RegisCursos.Name = "RegisCursos";
            this.RegisCursos.Size = new System.Drawing.Size(75, 25);
            this.RegisCursos.TabIndex = 0;
            this.RegisCursos.Text = "Cursos";
            this.RegisCursos.Click += new System.EventHandler(this.RegisCursos_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.Location = new System.Drawing.Point(190, -4);
            this.Contenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.OutlineThickness = 1F;
            this.Contenedor.PanelColor = System.Drawing.Color.White;
            this.Contenedor.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Contenedor.Rounding = new System.Windows.Forms.Padding(8);
            this.Contenedor.Size = new System.Drawing.Size(1152, 590);
            this.Contenedor.TabIndex = 3;
            // 
            // PanelDeAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 584);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.cuiPanelGradient1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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