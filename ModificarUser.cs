using Newtonsoft.Json.Linq;
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
    public partial class ModificarUser : Form
    {
        JObject ListaUsuarios;
        DataGridView datagUser;
        public ModificarUser(JObject listUsuarios, DataGridView dt)
        {
            InitializeComponent();
            ListaUsuarios = listUsuarios;
            datagUser = dt;
        }

        private void ModificarUser_Load(object sender, EventArgs e)
        {
            txtCedula.Text = (string)ListaUsuarios["Cedula"];
            txtUsuario.Text = (string)ListaUsuarios["Usuario"];
            txtCorreo.Text = (string)ListaUsuarios["Correo"];
            mskFechaPersona.Text = (string)ListaUsuarios["FechaNacimiento"];
            cboxRol.Text = (string)ListaUsuarios["TipoUsuario"];
        }
    }
}
