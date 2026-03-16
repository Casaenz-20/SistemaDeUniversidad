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
    public partial class RegistrarUsuarios : Form
    {
        List<JObject> usuarios = new List<JObject>();
        public RegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtID.Text) || String.IsNullOrWhiteSpace(txtNewUser.Text) || String.IsNullOrWhiteSpace(txtPasswordNew.Text) || String.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                errorProvider1.SetError(txtID, "El campo ID no puede estar vacío.");
                errorProvider1.SetError(txtNewUser, "El campo Usuario no puede estar vacío.");
                errorProvider1.SetError(txtPasswordNew, "El campo Contraseña no puede estar vacío.");
                errorProvider1.SetError(txtCorreo, "El campo Correo no puede estar vacío.");
            }
            else
            {
                if (usuarioExiste(txtID.Text))
                {
                    MessageBox.Show("El ID " + txtID.Text + " ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    JObject nuevoUsuario = new JObject
                    {
                        ["ID"] = txtID.Text,
                        ["Usuario"] = txtNewUser.Text,
                        ["Contraseña"] = txtPasswordNew.Text,
                        ["FechaNacimiento"] = StudentDate.Value.ToString("yyyy-MM-dd"),
                        ["Correo"] = txtCorreo.Text,
                        ["TipoUsuario"] = "Estudiante"

                    };
                    usuarios.Add(nuevoUsuario);
                    File.WriteAllText(Settings.Default.ListUser,JsonConvert.SerializeObject(usuarios, Formatting.Indented));
                    MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginUser loginUser = new LoginUser();
                    loginUser.Show();
                    this.Close();
                }
            }
        }

        private bool usuarioExiste(string text)
        {
            bool EsValido = usuarios.Any(u => u["ID"].ToString() == text);
            return EsValido;
        }

        private void RegistrarUsuarios_Load(object sender, EventArgs e)
        {

            usuarios = LeerUsuarios(Settings.Default.ListUser);
        }

        private List<JObject> LeerUsuarios(string listUser)
        {
            string contenido_usuario_tex = File.ReadAllText(listUser);
            return JsonConvert.DeserializeObject<List<JObject>>(contenido_usuario_tex) ?? new List<JObject>();
        }
    }
}
