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
    public partial class Cusos : UserControl
    {
        
        public  static List<JObject> cursos = new List<JObject>();

        public Cusos()
        {
            InitializeComponent();
        }

        public FormBorderStyle FormBorderStyle { get; internal set; }
        public bool TopLevel { get; internal set; }

        private void Cusos_Load(object sender, EventArgs e)
        {
            if (!ArchivoCursosExiste(Settings.Default.ListCursos))
            {
                CrearArchivo(Settings.Default.ListCursos);
            }
            cursos = LeerCursos(Settings.Default.ListCursos);
        }

        private List<JObject> LeerCursos(string listCursos)
        {
            string contenido_text_cursos = File.ReadAllText(listCursos);
            return JsonConvert.DeserializeObject<List<JObject>>(contenido_text_cursos) ?? new List<JObject>()
        }

        private void CrearArchivo(string listCursos)
        {
            File.WriteAllText(listCursos, "[]");
        }

        private Func<string, bool> ArchivoCursosExiste = (ruta) => File.Exists(ruta);


    }
}
