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
    public partial class LoginUser : Form
    {
        public static List<JObject> usuarios = new List<JObject>();
        int intentos = 3;
        public LoginUser()
        {
            InitializeComponent();
        }

        private void LoginUser_Load(object sender, EventArgs e)
        {
            if (!ArchivoUsuarioExiste(Settings.Default.ListUser))
            {
                CrearArchivo(Settings.Default.ListUser);
            }
            usuarios = LeerUsuarios(Settings.Default.ListUser);

        }

        private List<JObject> LeerUsuarios(string listUser)
        {
            string contenido_usuario_tex = File.ReadAllText(listUser);
            return JsonConvert.DeserializeObject<List<JObject>>(contenido_usuario_tex) ?? new List<JObject>();
        }

        private void CrearArchivo(string listUser)
        {
            File.WriteAllText(listUser, "[]");

        }

        Func<string, bool> ArchivoUsuarioExiste = (ruta) => File.Exists(ruta);



        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {

            RecuperarContra recuperarContraseña = new RecuperarContra();
            recuperarContraseña.Show();
            this.Hide();
        }

        private void txtIniciar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUser.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtUser, "El campo Usuario no puede estar vacío.");
                errorProvider1.SetError(txtPassword, "El campo Contraseña no puede estar vacío.");
            }
            else
            {
                if (!UsuariExiste(txtUser.Text))
                {
                    MessageBox.Show("El usuario " + txtUser.Text + " no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (!EstadoUser(Settings.Default.ListUser))
                    {
                        MessageBox.Show("El usuario " + txtUser.Text + " está inactivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        if (Usercoinside(txtUser.Text, txtPassword.Text))
                        {
                            int intentosRestantes = --intentos;
                            MessageBox.Show("La contraseña es incorrecta. Intentos restantes: " + intentosRestantes, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (intentosRestantes == 0)
                            {
                                MessageBox.Show("Has agotado todos los intentos.Su cuenta sera bloqueada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                CambioEstado(Settings.Default.ListUser);

                            }
                        }
                        else
                        {
                            if (RolUser(txtUser.Text))
                            {
                                MessageBox.Show("Bienvenido, " + txtUser.Text + "!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                PanelDeAdministrador adminPanel = new PanelDeAdministrador();
                                adminPanel.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Bienvenido, " + txtUser.Text + "!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                PanelEstudiantes userPanel = new PanelEstudiantes();
                                userPanel.Show();
                                this.Hide();
                            }
                        }
                    }
                }

            }

        }

        private bool RolUser(string text)
        {
            bool EsAdmin = usuarios.Any(u => u["Usuario"].ToString() == text && u["TipoUsuario"].ToString() == "Administrador");
            return EsAdmin;
        }

        private void CambioEstado(string listUser)
        {
            File.WriteAllText(listUser, JsonConvert.SerializeObject(usuarios.Select(u =>
            {
                if (u["Usuario"].ToString() == txtUser.Text)
                {
                    u["Activo"] = false;
                }
                return u;
            }).ToList(), Formatting.Indented));
        }

        private bool Usercoinside(string text1, string text2)
        {
            bool CoinsideUser = usuarios.Any(u => (string)u["Usuario"] == text2 && (string)u["Password"] == text1);
            return CoinsideUser;
        }

        private bool EstadoUser(string listUser)
        {
            bool EsActivo = usuarios.Any(u => u["Usuario"].ToString() == txtUser.Text && u["Activo"].ToObject<bool>());
            return EsActivo;
        }

        private bool UsuariExiste(string listUser)
        {

            {
                return usuarios.Any(u => u["Usuario"].ToString() == txtUser.Text);
            }
        }

        private void btnRegistrarUser_Click(object sender, EventArgs e)
        {
            RegistrarUsuarios registrarUsuarios = new RegistrarUsuarios();
            registrarUsuarios.Show();
            this.Hide();
        }
    }
}
