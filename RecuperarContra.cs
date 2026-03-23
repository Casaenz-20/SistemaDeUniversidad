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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeUniversidad
{
    public partial class RecuperarContra : Form
    {
        List<JObject> usuarios = new List<JObject>();
        public RecuperarContra()
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            string correoDestino = txtCorreoRecuperar.Text.Trim();

            if (CorreoExiste(correoDestino))
            {
                // Buscamos ignorando mayúsculas/minúsculas
                var usuario = usuarios.FirstOrDefault(u => u["Correo"].ToString().Trim().ToLower() == correoDestino.ToLower());
                string contraseña = usuario?["Contraseña"]?.ToString();

                if (!string.IsNullOrEmpty(contraseña))
                {
                    try
                    {
                        // --- CONFIGURACIÓN DE ENVÍO ---
                        string miCorreo = "upa284581@gmail.com";
                        string miPasswordApp = "qnlc sjqg qufa puob";

                        MailMessage correo = new MailMessage();
                        correo.From = new MailAddress(miCorreo, "Sistema Universitario"); // Nombre que verá el usuario
                        correo.To.Add(correoDestino);
                        correo.Subject = "Recuperación de Contraseña";
                        correo.Body = $"Hola,\n\nHas solicitado recuperar tu contraseña.\nTu clave de acceso es: {contraseña}\n\nPor seguridad, te recomendamos cambiarla pronto.";
                        correo.IsBodyHtml = false;

                        SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com")
                        {
                            Port = 587,
                            Credentials = new NetworkCredential(miCorreo, miPasswordApp),
                            EnableSsl = true
                        };

                        // Enviamos el correo
                        clienteSmtp.Send(correo);

                        MessageBox.Show("La contraseña ha sido enviada a su correo con éxito.", "Envío Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("El correo " + txtCorreoRecuperar.Text + " no esta registrado");
            }
        }
        

        private bool CorreoExiste(object text)
        {
            bool existeCorreo = usuarios.Any(u => u["Correo"].ToString() == txtCorreoRecuperar.Text);
            return existeCorreo;
        }

        private void RecuperarContra_Load(object sender, EventArgs e)
        {
            string rutaArchivo = Settings.Default.ListUser;

            if (File.Exists(rutaArchivo))
            {
                string contenidoJson = File.ReadAllText(rutaArchivo);
               
                usuarios = JsonConvert.DeserializeObject<List<JObject>>(contenidoJson);

                if (usuarios == null) usuarios = new List<JObject>();
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de base de datos (JSON).");
            }
        }
    }
}
