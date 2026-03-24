using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeUniversidad
{
    public partial class PanelDeAdministrador : Form
    {
        public PanelDeAdministrador()
        {
            InitializeComponent();
        }

        

        private void RegisCursos_Click_1(object sender, EventArgs e)
        {

            Cusos registroCursos = new Cusos();
            Contenedor.Controls.Clear();
            registroCursos.TopLevel = false;
            registroCursos.FormBorderStyle = FormBorderStyle.None;
            registroCursos.Dock = DockStyle.Fill;
            Contenedor.Controls.Add(registroCursos);

            registroCursos.Show();
        }

        private void btnUsuariosPanel_Click(object sender, EventArgs e)
        {

            AdministrarUsuarios administrarUsuarios = new AdministrarUsuarios();
            Contenedor.Controls.Clear();
            administrarUsuarios.TopLevel = false;
            administrarUsuarios.FormBorderStyle = FormBorderStyle.None;
            administrarUsuarios.Dock = DockStyle.Fill;
            Contenedor.Controls.Add(administrarUsuarios);

            administrarUsuarios.Show();
        }

        private void PanelDeAdministrador_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.FromArgb(31, 40, 62); // Fondo muy oscuro

            // --- Diseño del Panel Lateral (Estilo Cristal) ---
            // (Asumiendo que es panelSideMenu)
            GunaPanel.BackColor = Color.FromArgb(30, 255, 255, 255); // Semitransparente
            GunaPanel.Padding = new Padding(10, 30, 10, 10); // Margen interno para los botones
            GunaPanel.BorderRadius = 15; // Requiere Guna2Panel o CuoreUI Panel
            GunaPanel.ShadowDecoration.Enabled = true; // Sombra sutil
            GunaPanel.ShadowDecoration.Color = Color.Black;
           

            // --- Diseño de Botones de FontAwesome.Sharp ---
            ConfigurarBotonesMenuSideBar(new List<FontAwesome.Sharp.IconButton> { btnUsuariosPanel, RegisCursos,btnVolverLogin });
        }



        private void ConfigurarBotonesMenuSideBar(List<FontAwesome.Sharp.IconButton> botones)
        {
            foreach (var btn in botones)
            {
                // 1. Estilo Base Limpio
                btn.BackColor = Color.Transparent; // Usar el fondo del panel
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0; // Eliminar bordes para look "Flat"

                // 2. Alineación y Espaciado (Al estilo Sidebar moderno)
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.ImageAlign = ContentAlignment.MiddleLeft;
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn.Padding = new Padding(20, 0, 0, 0); // Espacio a la izquierda del icono
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular); // Fuente más limpia

                // 3. Colores Normales (Atacados por el diseño oscuro)
                btn.ForeColor = Color.FromArgb(148, 163, 184); // Gris suave
                btn.IconColor = Color.FromArgb(148, 163, 184);

                // 4. Efectos Hover (Cuando el mouse pasa por encima)
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 255, 255, 255);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 255, 255, 255);
            }
        }

        private void btnVolverLogin_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea cerrar sesión?",
        "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                LoginUser login = new LoginUser();
                login.Show();
                this.Dispose();
            }
        }
    }
}
