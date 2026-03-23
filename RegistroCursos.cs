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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeUniversidad
{
    public partial class RegistroCursos : UserControl
    {
        List<JObject> Matricula = new List<JObject>();
        public RegistroCursos() 
        {
            InitializeComponent();
        }

        private void RegistroCursos_Load(object sender, EventArgs e)
        {
            Matricula = LeerArchicho(Settings.Default.ListMatricula);   
        }

        private List<JObject> LeerArchicho(string listMatricula)
        {
            string contenido_archico = File.ReadAllText(listMatricula);
            return JsonConvert.DeserializeObject<List<JObject>>(contenido_archico) ?? new List<JObject>();
        }

        private void btnBuscarMaatriculas_Click(object sender, EventArgs e)
        {
            string id = txtCedula.Text;
            if (String.IsNullOrWhiteSpace(id))
            {
                errorProvider1.SetError(txtCedula,"No nuede estar en blanco");
            }
            else
            {
                errorProvider1.Clear();
                
            }

            if (CedulaExiste(id))
            {
                BuscarCursosPorEstudiante(id);
            }
            else
            {
                MessageBox.Show("Esta Cedula no esta registrada");
            }

            
        }

        private bool CedulaExiste(string text)
        {
            bool existeCedula = Matricula.Any(u => u["CedulaEstudiante"].ToString() == txtCedula.Text);
            return existeCedula;
        }



        /// <summary>
        /// Funcion para buscar los cursos matriculados por estudiantes
        /// </summary>
        /// <param name="idBuscado"></param>
        private void BuscarCursosPorEstudiante(string idBuscado)
        {
            string rutaArchivo = Settings.Default.ListMatricula;

            if (File.Exists(rutaArchivo))
            {
                // 1. Leer todo el contenido del archivo
                string json = File.ReadAllText(rutaArchivo);

                // 2. Deserializar a una lista de objetos
                List<JObject> todasLasMatriculas = JsonConvert.DeserializeObject<List<JObject>>(json);

                // 3. Filtrar usando LINQ según el ID del estudiante
                var cursosFiltrados = todasLasMatriculas
                    .Where(m => m["CedulaEstudiante"].ToString() == idBuscado)
                    .ToList();

                datagMatricula.DataSource = null;
                datagMatricula.DataSource = cursosFiltrados;
            }
            else
            {
                MessageBox.Show("El archivo de datos no existe.");
            }
        }
    }
}
