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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeUniversidad
{
    
    public partial class CambiarContraseña : UserControl

    {
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
            
        }

        public static string GenerarCodigo(int longitud = 6)
        {
            Random random = new Random();
            string codigo = "";
            for(int i = 0; i < longitud; i++)
            {
                codigo += random.Next(0, 10).ToString();
            }
            return codigo;
        }
    }
}
