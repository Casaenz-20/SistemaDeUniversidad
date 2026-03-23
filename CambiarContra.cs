using CuoreUI.Controls;
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
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeUniversidad
{

    public partial class CambiarContraseña : UserControl

    {
        string CodigoGenerado;
        public static List<JObject> usuarios = new List<JObject>();
        public CambiarContraseña()
        {
            InitializeComponent();
            
        }

        private void CambiarContraseña_Load(object sender, EventArgs e)
        {
            usuarios = (List<JObject>)LeerArchivo(Settings.Default.ListUser);
        }

        private object LeerArchivo(string listUser)
        {
            string Leer_Archivo = File.ReadAllText(listUser);
            return JsonConvert.DeserializeObject<List<JObject>>(Leer_Archivo) ?? new List<JObject>();
        }

        private void btnNewPassworld_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCorreoEstudiante.Text))
            {
                errorProvider1.SetError(txtCorreoEstudiante, "Este campo no debe de estar vacio");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (String.IsNullOrWhiteSpace(txtNombreEstudiante.Text))
            {
                errorProvider1.SetError(txtNombreEstudiante, "Este campo no debe de estar vacio");

            }
            else
            {
                errorProvider1.Clear();
            }

            if (String.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                errorProvider1.SetError(txtNombreEstudiante, "Este campo no debe de estar vacio");
            }
            else
            {
                errorProvider1.Clear();
            }



            if (ExisteCorreo(txtCorreoEstudiante.Text))
            {
                CodigoGenerado = GenerarCodigo();
                string Correouser = txtCorreoEstudiante.Text;

                // Buscamos ignorando mayúsculas/minúsculas
                var usuario = usuarios.FirstOrDefault(u => u["Correo"].ToString().Trim().ToLower() == Correouser.ToLower());

                try
                {
                    // --- CONFIGURACIÓN DE ENVÍO ---
                    string miCorreo = "upa284581@gmail.com";
                    string miPasswordApp = "qnlc sjqg qufa puob";

                    MailMessage correo = new MailMessage();
                    correo.From = new MailAddress(miCorreo, "Sistema Universitario"); // Nombre que verá el usuario
                    correo.To.Add(Correouser);
                    correo.Subject = "Codigo de Verificacion";
                    correo.Body = $"Hola,\n\nHas solicitado un codigo para cambiar tu contraseña.\nTu codigó de verificacion es: {CodigoGenerado}\n\nSi no fue no lo solicito por favao conumicarse con la institucion.";
                    correo.IsBodyHtml = false;

                    SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential(miCorreo, miPasswordApp),
                        EnableSsl = true
                    };

                    // Enviamos el correo
                    clienteSmtp.Send(correo);

                    MessageBox.Show("Se envio un codigo al correo del estudiante.", "Envío Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigodeVerificacion.Visible = true;
                    btnConfirmCode.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }




            }
            else
            {
                MessageBox.Show($"El correo {txtCorreoEstudiante.Text} No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ExisteCorreo(string text)
        {
            bool existeUser = usuarios.Any(u => u["Correo"].ToString() == txtCorreoEstudiante.Text);
            return existeUser;
        }

        

        public static string GenerarCodigo(int longitud = 6)
        {
            Random random = new Random();
            string codigo = "";
            for (int i = 0; i < longitud; i++)
            {
                 codigo+= random.Next(0, 10).ToString();
                 
                
               
            }
            return codigo;
        }

        private void btnConfirmCode_Click(object sender, EventArgs e)
        {
            if (CodigoCoinside(txtCodigodeVerificacion.Text))
            {
                
                try
                {
                    GuardarNuevaContra(Settings.Default.ListUser);
                    MessageBox.Show("Contraseña actualizada con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El código no coincide.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarNuevaContra(string listUser)
        {
            string jsonActual = File.ReadAllText(Settings.Default.ListCursos);
            List<JObject> listaUsuarios = JsonConvert.DeserializeObject<List<JObject>>(jsonActual);

           
            var usuario = listaUsuarios.FirstOrDefault(u => u["Usuario"]?.ToString() == txtNombreEstudiante.Text);

            if (usuario != null)
            {
                
                usuario["Contraseña"] = txtNewPassword.Text;

                
                string nuevoJson = JsonConvert.SerializeObject(listaUsuarios, Formatting.Indented);
                File.WriteAllText(Settings.Default.ListUser, nuevoJson);
            }
        }

        private bool CodigoCoinside(string text)
        {
            return txtCodigodeVerificacion.Text == CodigoGenerado;
        }

        
    }
}
