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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datagMatricula.SelectedRows.Count > 0)
            {
                // Confirmación de seguridad
                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    // 2. Obtener el ID o valor único de la fila seleccionada
                    // Supongamos que la primera columna (índice 0) tiene el ID o Nombre
                    string idSeleccionado = datagMatricula.SelectedRows[0].Cells[0].Value.ToString();

                    // 3. Eliminar de la lista y actualizar JSON
                    EliminarDeJson(idSeleccionado);

                    MessageBox.Show("Registro eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila completa de la tabla.");
            }
        }

        private void EliminarDeJson(string idSeleccionado)
        {
            string rutaArchivo = Settings.Default.ListMatricula; // Ajusta a tu ruta real

            if (File.Exists(rutaArchivo))
            {
                
                string jsonExistente = File.ReadAllText(rutaArchivo);

                // Convertir a lista de objetos (usa tu clase, ej: Curso o Usuario)
                var lista = JsonConvert.DeserializeObject<List<JObject>>(jsonExistente);

                // LINQ: Filtrar la lista para quitar el elemento que coincida con el ID
                // Reemplaza "Id" por el nombre de la propiedad real de tu clase
                lista.RemoveAll(x => x["CedulaEstudiante"].ToString() == txtCedula.Text);

                // Serializar la nueva lista y guardar
                string nuevoJson = JsonConvert.SerializeObject(lista, Formatting.Indented);
                File.WriteAllText(rutaArchivo, nuevoJson);
            }
        }
    }
}
