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

        private void RegisCursos_Click(object sender, EventArgs e)
        {
            Cusos registroCursos = new Cusos();
            Contenedor.Controls.Clear();
            registroCursos.TopLevel = false;
            registroCursos.FormBorderStyle = FormBorderStyle.None;
            registroCursos.Dock = DockStyle.Fill;
            Contenedor.Controls.Add(registroCursos);

            registroCursos.Show();
        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {
            AdministrarUsuarios administrarUsuarios = new AdministrarUsuarios();
            Contenedor.Controls.Clear();
            administrarUsuarios.TopLevel = false;
            administrarUsuarios.FormBorderStyle = FormBorderStyle.None;
            administrarUsuarios.Dock = DockStyle.Fill;
            Contenedor.Controls.Add(administrarUsuarios);

            administrarUsuarios.Show();
        }
    }
}
