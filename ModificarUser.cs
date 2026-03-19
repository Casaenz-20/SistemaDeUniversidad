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
            txtContrasena.Text = (string)ListaUsuarios["Contraseña"];


        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("¿Deseas guardar los cambios realizados?", "Confirmar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pregunta == DialogResult.Yes)
            {
                // Buscamos el objeto específico dentro de la lista global
                JObject usuario_Encontrado = AdministrarUsuarios.usuarios.FirstOrDefault(u => (string)u["ID"] == txtCedula.Text);

                if (usuario_Encontrado != null)
                {
                    // Modificamos el objeto encontrado directamente
                    usuario_Encontrado["ID"] = txtCedula.Text;
                    usuario_Encontrado["Usuario"] = txtUsuario.Text;
                    usuario_Encontrado["FechaNacimiento"] = mskFechaPersona.Text; 
                    usuario_Encontrado["Correo"] = txtCorreo.Text;               
                    usuario_Encontrado["TipoUsuario"] = cboxRol.Text;
                    usuario_Encontrado["Activo"] = chkEstado.Checked;
                    usuario_Encontrado["Contraseña"] = txtContrasena.Text;

                    // Guardamos la lista completa (que ya contiene al usuario modificado)
                    GuardarCambiosJSON(Settings.Default.ListUser);

                    AdministrarUsuarios.ImprrimirListaUser(datagUser, AdministrarUsuarios.usuarios);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario para actualizar.");
                }
            }
        }

        private void GuardarCambiosJSON(string listUser)
        {
           File.WriteAllText(listUser, JsonConvert.SerializeObject(AdministrarUsuarios.usuarios, Formatting.Indented));
        }
    }
}
