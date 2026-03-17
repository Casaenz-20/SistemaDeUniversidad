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

        public static List<JObject> cursos = new List<JObject>();

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
            return JsonConvert.DeserializeObject<List<JObject>>(contenido_text_cursos) ?? new List<JObject>();
        }

        private void CrearArchivo(string listCursos)
        {
            File.WriteAllText(listCursos, "[]");
        }

        private Func<string, bool> ArchivoCursosExiste = (ruta) => File.Exists(ruta);

        private void btnGuardarCurso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCurso.Text) || string.IsNullOrWhiteSpace(txtCodigoCurso.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || cboResinto.SelectedIndex == -1)
            {
                errorProvider1.SetError(txtNombreCurso, "Por favor, ingrese el nombre del curso.");
                errorProvider1.SetError(txtCodigoCurso, "Por favor, ingrese el código del curso.");
                errorProvider1.SetError(txtPrecio, "Por favor, ingrese el precio del curso.");
                errorProvider1.SetError(cboResinto, "Por favor, seleccione el recinto del curso.");
            }
            else
            {
                if (CursoExite(txtCodigoCurso.Text))
                {
                    MessageBox.Show("El código del curso ya existe. Por favor, ingrese un código único.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CursoExite(string text)
        {
            bool YaExisteCurso =  cursos.Any(curso => curso["Codigo"]?.ToString() == txtCodigoCurso.Text);
            return  YaExisteCurso;
        }
    }
}
