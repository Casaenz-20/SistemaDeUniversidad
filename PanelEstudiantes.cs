using FontAwesome.Sharp;
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
    public partial class PanelEstudiantes : Form
    {
        public PanelEstudiantes()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
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

        private void btnVerCursos_Click(object sender, EventArgs e)
        {
            VerCursosDisponibles cursosDisponibles = new VerCursosDisponibles();
            ContenedorEstudiantes.Controls.Clear();
            cursosDisponibles.TopLevel = false;
            cursosDisponibles.FormBorderStyle = FormBorderStyle.None;
            cursosDisponibles.Dock = DockStyle.Fill;
            ContenedorEstudiantes.Controls.Add(cursosDisponibles);

            cursosDisponibles.Show();
        }

        private void CambiarContra_Click(object sender, EventArgs e)
        {
            CambiarContraseña con = new CambiarContraseña();
            ContenedorEstudiantes.Controls.Clear();
            ContenedorEstudiantes.Controls.Add(con);

        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            RegistrarMatricula registro = new RegistrarMatricula();
            ContenedorEstudiantes.Controls.Clear();
            ContenedorEstudiantes.Controls.Add(registro);
        }

        private void btnRegistrMatricula_Click(object sender, EventArgs e)
        {
            RegistroCursos cursosRegistrados = new RegistroCursos();
            ContenedorEstudiantes.Controls.Clear();
            ContenedorEstudiantes.Controls.Add(cursosRegistrados);
        }

        private void PanelEstudiantes_Load(object sender, EventArgs e)
        {
            Color colorPanelOscuro = Color.FromArgb(31, 40, 62); // Azul Noche Muy Oscuro
            Color colorAcento = Color.FromArgb(0, 180, 216);    // Cian Vibrante
            Color colorTextoOscuro = Color.White;
            Color colorFondoClaro = Color.FromArgb(244, 246, 249);

            cuiPanel1.BackColor = colorPanelOscuro;


            // --- Configurar Botones (FontAwesome.Sharp) ---
            List<IconButton> misBotones = new List<IconButton> {
        btnMatricular, btnRegistrMatricula, CambiarContra, btnVerCursos,iconButton1
    };

            foreach (var btn in misBotones)
            {
                // Estilo Base Moderno
                btn.BackColor = Color.Transparent; // Usar el fondo del panel
                btn.ForeColor = colorTextoOscuro;
                btn.IconColor = colorTextoOscuro;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.ImageAlign = ContentAlignment.MiddleLeft;
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn.Padding = new Padding(20, 0, 0, 0); // Espacio a la izquierda del icono
                btn.Font = new Font("Century Gothic", 10F, FontStyle.Regular); // Fuente más moderna

                // Efectos al pasar el mouse
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 62, 80); // Un gris-azul sutil
            }

            // --- Botón Cerrar Sesión (Acento Colorido) ---
            // Este botón lo podemos hacer resaltar más
            iconButton1.BackColor = Color.FromArgb(192, 57, 43); // Un rojo sutil
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60); // Rojo más brillante
            iconButton1.IconChar = IconChar.SignOutAlt;
            iconButton1.Padding = new Padding(10, 0, 0, 0);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void PanelEstudiantes_Resize(object sender, EventArgs e)
        {
            // Verificamos si el estado de la ventana es Minimizado
            if (this.WindowState == FormWindowState.Minimized)
            {
                // 1. Ocultamos el formulario de la barra de tareas
                this.Hide();

                // 2. Configuramos y mostramos la notificación
                notifyIcon1.Visible = true; // Asegurarse de que el icono esté activo
                notifyIcon1.BalloonTipTitle = "Aplicación en segundo plano";
                notifyIcon1.BalloonTipText = "La aplicación se sigue ejecutando aquí.";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;

                // Muestra el globo por 3 segundos (3000 ms)
                notifyIcon1.ShowBalloonTip(3000);
            }
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
