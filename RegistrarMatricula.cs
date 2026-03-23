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
    public partial class RegistrarMatricula : UserControl
    {
        public static List<JObject> Matricula = new List<JObject>();
        List<JObject> usuarios = new List<JObject>();
        List <JObject> Cursos = new List<JObject>();
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

            usuarios = LeerArchivoUser(Settings.Default.ListUser);
            Cursos = LeerArchivoCurso(Settings.Default.ListCursos);
        }

        private List<JObject> LeerArchivoCurso(string listCursos)
        {
            string contenido_text_cursos = File.ReadAllText(listCursos);
            return JsonConvert.DeserializeObject<List<JObject>>(contenido_text_cursos) ?? new List<JObject>();
        }

        private List<JObject> LeerArchivoUser(string listUser)
        {
            string Leer_Archivo = File.ReadAllText(listUser);
            return JsonConvert.DeserializeObject<List<JObject>>(Leer_Archivo) ?? new List<JObject>();
        }

        private void CrearArchivo(string listMatricula)
        {
            File.WriteAllText(listMatricula, "[]");

        }

        private Func<string,bool> ArchivoExiste = (ruta) => File.Exists(ruta);

        private void btnMatricularcurso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedulaEstudiante.Text) || string.IsNullOrWhiteSpace(txtCodigocursoMatri.Text))
            {
                MessageBox.Show("Por favor, complete los campos necesarios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecioCurso.Text, out decimal precio))
            {
                MessageBox.Show("El precio del curso no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Crear el objeto JObject
            JObject nuevaMatricula = new JObject
            {
                ["CedulaEstudiante"] = txtCedulaEstudiante.Text,
                ["CodigoCurso"] = txtCodigocursoMatri.Text,
                ["NombreCurso"] = txtNombreCurso.Text, // Corregido: quité el espacio inicial " NombreCurso"
                ["PrecioCurso"] = precio
            };

            try
            {
                string rutaArchivo = Settings.Default.ListMatricula;
                List<JObject> listaMatriculas = new List<JObject>();

                // 3. Leer si el archivo existe
                if (File.Exists(rutaArchivo))
                {
                    string jsonExistente = File.ReadAllText(rutaArchivo);
                    // Si el archivo está vacío, evitamos el error con ??
                    listaMatriculas = JsonConvert.DeserializeObject<List<JObject>>(jsonExistente) ?? new List<JObject>();
                }

                // 4. Agregar y GUARDAR (Paso vital)
                listaMatriculas.Add(nuevaMatricula);

                string jsonActualizado = JsonConvert.SerializeObject(listaMatriculas, Formatting.Indented);
                File.WriteAllText(rutaArchivo, jsonActualizado);

                MessageBox.Show("Matrícula guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // LimpiarCampos(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la matrícula: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigocursoMatri_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
