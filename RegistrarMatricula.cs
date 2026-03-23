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
    public partial class RegistrarMatricula : UserControl
    {
        List<JObject> Matricula = new List<JObject>();
        public RegistrarMatricula()
        {
            InitializeComponent();
        }

        private void RegistrarMatricula_Load(object sender, EventArgs e)
        {
            if (!ArchivoExiste(Settings.Default.ListMatricula))
            {
                CrearArchivo(Settings.Default.ListMatricula);
            }
        }

        private void CrearArchivo(string listMatricula)
        {
            File.WriteAllText(listMatricula, "[]");

        }

        private Func<string,bool> ArchivoExiste = (ruta) => File.Exists(ruta);
    }
}
