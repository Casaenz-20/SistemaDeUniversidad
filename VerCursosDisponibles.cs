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
    public partial class VerCursosDisponibles : Form
    {
        List<JObject> cursos = new List<JObject>();
        public VerCursosDisponibles()
        {
            InitializeComponent();
        }

        private void VerCursosDisponibles_Load(object sender, EventArgs e)
        {
            if (!ArchivoCursosExiste(Settings.Default.ListCursos))
            {
                CrearArchivo(Settings.Default.ListCursos);
            }
            cursos = LeerCursos(Settings.Default.ListCursos);

            ImprimirListaCursos(datagVerCursos, cursos);
        }

        private List<JObject> LeerCursos(string listCursos)
        {
            string contenido_text_cursos = File.ReadAllText(listCursos);
            return JsonConvert.DeserializeObject<List<JObject>>(contenido_text_cursos) ?? new List<JObject>();
        }

        private void CrearArchivo(string listCursos)
        {
            throw new NotImplementedException();
        }

        private void ImprimirListaCursos(object datagCursos, List<JObject> cursos)
        {
          datagVerCursos.Rows.Clear();
           foreach(var vercursos in cursos)
            {
                datagVerCursos.Rows.Add(vercursos["Codigo"], vercursos["Nombre"], vercursos["Precio"], vercursos["Recinto"]);
            }
        }

        private Func<string, bool> ArchivoCursosExiste = (ruta) => File.Exists(ruta);
    }
}
