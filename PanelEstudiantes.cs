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
            LoginUser login = new LoginUser();
            login.Show();
            this.Close();
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
    }
}
