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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeUniversidad
{
    public partial class LoginUser : Form

    {
        private bool showPassword = false;
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

            DiseñarFormulario();
        }

        /// <summary>
        /// Lee el archivo JSON de los usurios
        /// </summary>
        /// <param name="listUser"></param>
        /// <returns></returns>

        private List<JObject> LeerUsuarios(string listUser)
        {
            string contenido_usuario_tex = File.ReadAllText(listUser);
            return JsonConvert.DeserializeObject<List<JObject>>(contenido_usuario_tex) ?? new List<JObject>();
        }

        private void CrearArchivo(string listUser)
        {
            File.WriteAllText(listUser, "[]");

        }

        /// <summary>
        /// Revisa si el arachivo JSon existe en los archovos del proyecto
        /// </summary>
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

        /// <summary>
        /// Funcion que revisa que rol tiene el usurio para mostrar los paneles dependiendo del rol que tenga el usuario
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
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
                return usuarios.Any(u => u["Usuario"]?.ToString() == txtUser.Text);
            }
        }

        private void btnRegistrarUser_Click(object sender, EventArgs e)
        {
            RegistrarUsuarios registrarUsuarios = new RegistrarUsuarios();
            registrarUsuarios.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            if(showPassword)
            {
                txtPassword.PasswordChar ='\0';
                pictureBox1.Image = Resources.visibilidad;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                pictureBox1.Image = Resources.ojo_cerrado;
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                e.SuppressKeyPress = true;

                
                txtPassword.Focus();
            }
        }


        private void DiseñarFormulario()
        {
            // --- 1. FONDO DEL FORMULARIO (GRADIENTE) ---
            guna2GradientPanel1.FillColor = Color.FromArgb(206, 142, 169); // Rosa suave
            guna2GradientPanel1.FillColor2 = Color.FromArgb(41, 74, 126); // Azul profundo
            guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;

            
            // Usamos una región para hacerlo circular sin que de error de BorderRadius
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Region = new Region(gp);

            // --- 3. TEXTBOXES (GUNA2TEXTBOX) ---
            // Usamos FontAwesome para los iconos y así evitar errores de Resources
            
            txtPassword.PasswordChar = '●';

            // --- 4. LINKLABEL 'Forgot Password?' ---
            kryptonLinkLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(110, 110, 130);
            kryptonLinkLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(110, 110, 130);
            kryptonLinkLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 9F);
            kryptonLinkLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;

            // --- 5. BOTÓN LOGIN (cuiButton de CuoreUI) ---
            txtIniciar.NormalBackground = Color.FromArgb(200, 255, 255, 255);
            txtIniciar.NormalForeColor = Color.FromArgb(15, 38, 77);
            txtIniciar.HoverBackground = Color.FromArgb(230, 255, 255, 255);
            txtIniciar.HoverForeColor = Color.FromArgb(15, 38, 77);
            txtIniciar.NormalOutline = Color.Transparent;
            txtIniciar.OutlineThickness = 0;
            txtIniciar.Rounding = new Padding(15);
        }



    }
}
