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
    public partial class AdministrarUsuarios : Form
    {
        List<JObject> usuarios = new List<JObject>();
        public AdministrarUsuarios()
        {
            InitializeComponent();
        }

        private void AdministrarUsuarios_Load(object sender, EventArgs e)
        {
            if (!ArchivoExiste(Settings.Default.ListUser))
            {
                CrearArchivo(Settings.Default.ListUser);
            }
            usuarios = LeerUsuarios(Settings.Default.ListUser);
            datagridUsuarios.Rows.Clear();
            foreach (var usuario in usuarios)
            {
                datagridUsuarios.Rows.Add(usuario["ID"], usuario["Usuario"], usuario["FechaNacimiento"], usuario["Correo"], usuario["TipoUsuario"]);
            }
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

        private Func<string, bool> ArchivoExiste = (ruta) => File.Exists(ruta);
    }
}
