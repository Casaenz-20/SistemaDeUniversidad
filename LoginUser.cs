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
        List<JObject>  usuarios = new List<JObject>();
        public LoginUser()
        {
            InitializeComponent();
        }

        private void txtRegistrarUser_Click(object sender, EventArgs e)
        {
            RegistrarUsuarios registrarUsuarios = new RegistrarUsuarios();
            registrarUsuarios.Show();
            this.Hide();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContra recuperarContraseña = new RecuperarContra();
            recuperarContraseña.Show();
            this.Hide();
        }
    }
}
