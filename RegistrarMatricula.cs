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

        private void btnMatricularcurso_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos tengan información
            if (string.IsNullOrWhiteSpace(txtCedulaEstudiante.Text) || string.IsNullOrWhiteSpace(txtCodigocursoMatri.Text))
            {
                MessageBox.Show("Por favor, complete los campos de Cédula y Código de Curso.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Crear el objeto con los datos de los TexBox
            JObject nuevaMatricula = new JObject
            {
                ["CedulaEstudiante"] = txtCedulaEstudiante.Text,
                ["CodigoCurso"] = txtCodigocursoMatri.Text,
                [" NombreCurso"] = txtNombreCurso.Text,
                ["PrecioCurso"] = decimal.Parse(txtPrecioCurso.Text) // Asegúrate que sea un número válido
            };

            try
            {
                // 3. Leer lista actual del archivo JSON
                string rutaArchivo = Settings.Default.ListMatricula;

                //if (File.Exists(rutaArchivo))
                //{
                //    string jsonExistente = File.ReadAllText(rutaArchivo);
                //    listaMatriculas = JsonConvert.DeserializeObject<List<Matricula>>(jsonExistente) ?? new List<Matricula>();
                //}

                // 4. Agregar la nueva matrícula y guardar
                Matricula.Add(nuevaMatricula);

                MessageBox.Show("Matrícula guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: Limpiar campos después de guardar
                //LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void txtCodigocursoMatri_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
