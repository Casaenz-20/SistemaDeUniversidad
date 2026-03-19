using Guna.UI2.WinForms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SistemaDeUniversidad.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeUniversidad
{
    public partial class ModificarUser : Form
    {
        
        JObject ListaUsuarios;
        Guna2DataGridView datagUser;
        public ModificarUser(JObject listUsuarios, DataGridView dt)
        {
            InitializeComponent();
            ListaUsuarios = listUsuarios;
            datagUser = (Guna2DataGridView)dt;
        }

        private void ModificarUser_Load(object sender, EventArgs e)
        {
            txtCedula.Text = (string)ListaUsuarios["ID"];
            txtUsuario.Text = (string)ListaUsuarios["Usuario"];
            txtCorreo.Text = (string)ListaUsuarios["FechaNacimiento"];
            mskFechaPersona.Text = (string)ListaUsuarios["Correo"];
            cboxRol.Text = (string)ListaUsuarios["TipoUsuario"];
           chkEstado.Checked = (bool)ListaUsuarios["Activo"];


        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("¿Deseas guardar los cambios realizados?", "Confirmar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pregunta == DialogResult.Yes)
            {
                JObject usuario_Encontrado = AdministrarUsuarios.usuarios.FirstOrDefault(u => (string)u["ID"] == txtCedula.Text);
                if (usuario_Encontrado != null)
                {
                    ListaUsuarios["ID"] = txtCedula.Text;
                    ListaUsuarios["Usuario"] = txtUsuario.Text;
                    ListaUsuarios["FechaNacimiento"] = txtCorreo.Text;
                    ListaUsuarios["Correo"] = mskFechaPersona.Text;
                    ListaUsuarios["TipoUsuario"] = cboxRol.Text;
                    ListaUsuarios["Activo"] = chkEstado.Checked;
                    GuardarCambiosJSON(Settings.Default.ListUser, ListaUsuarios);
                    AdministrarUsuarios.ImprrimirListaUser(datagUser, AdministrarUsuarios.usuarios);
                    this.Close();
                }
            }
        }

        private void GuardarCambiosJSON(string listUser, JObject listaUsuarios)
        {
           File.WriteAllText(listUser, JsonConvert.SerializeObject(AdministrarUsuarios.usuarios, Formatting.Indented));
        }
    }
}
