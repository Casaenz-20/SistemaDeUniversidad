using Krypton.Toolkit;
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

            ImprimirListaCursos(datagCursos, cursos);
        }

        private List<JObject> LeerCursos(string listCursos)
        {
            string contenido_text_cursos = File.ReadAllText(listCursos);
            return JsonConvert.DeserializeObject<List<JObject>>(contenido_text_cursos) ?? new List<JObject>();
        }


        /// <summary>
        /// Crea el Archivo solo si se detecta que no existe
        /// </summary>
        /// <param name="listCursos"></param>
        private void CrearArchivo(string listCursos)
        {
            File.WriteAllText(listCursos, "[]");
        }

        /// <summary>
        /// Revisa si el archico JSON existe
        /// </summary>
        private Func<string, bool> ArchivoCursosExiste = (ruta) => File.Exists(ruta);

        private void btnGuardarCurso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCurso.Text) || string.IsNullOrWhiteSpace(txtCodigoCurso.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                errorProvider1.SetError(txtNombreCurso, "Por favor, ingrese el nombre del curso.");
                errorProvider1.SetError(txtCodigoCurso, "Por favor, ingrese el código del curso.");
                errorProvider1.SetError(txtPrecio, "Por favor, ingrese el precio del curso.");
            }
            else
            {
                if (CursoExite(txtCodigoCurso.Text))
                {
                    MessageBox.Show("El código del curso ya existe. Por favor, ingrese un código único.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    JObject nuevoCurso = new JObject
                    {
                        ["Nombre"] = txtNombreCurso.Text,
                        ["Codigo"] = txtCodigoCurso.Text,
                        ["Precio"] = txtPrecio.Text,

                    };
                    cursos.Add(nuevoCurso);
                    File.WriteAllText(Settings.Default.ListCursos, JsonConvert.SerializeObject(cursos, Formatting.Indented));
                    MessageBox.Show("Curso guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ImprimirListaCursos(datagCursos, cursos);
                    LimpiarCampos();
                }
            }
        }

        public static void ImprimirListaCursos(KryptonDataGridView datagCursos, List<JObject> cursos)
        {
            datagCursos.Rows.Clear();
            foreach(var nuevoCurso in cursos)
            {
                datagCursos.Rows.Add(nuevoCurso["Codigo"], nuevoCurso["Nombre"], nuevoCurso["Precio"]);
            }
        }

        private void LimpiarCampos()
        {
           txtCodigoCurso.Clear();
           txtPrecio.Clear();
            txtNombreCurso.Clear();
        }

        private bool CursoExite(string text)
        {
            bool YaExisteCurso =  cursos.Any(curso => curso["Codigo"]?.ToString() == txtCodigoCurso.Text);
            return  YaExisteCurso;
        }

        private void txtCodigoCurso_TextChanged(object sender, EventArgs e)
        {
            var filtro = txtCodigoCurso.Text.Trim();
            var cursosFiltrados = cursos.Where(c => c["Codigo"]?.ToString().Contains(filtro) == true).ToList();
            datagCursos.Rows.Clear();
            foreach (var curso in cursosFiltrados)
            {
                datagCursos.Rows.Add(curso["Codigo"], curso["Nombre"], curso["Precio"]);
            }
        }


        /// <summary>
        /// Obtiene la imformacion del la columna selecionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datagCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionada = datagCursos.Rows[e.RowIndex];

                    
                    txtCodigoCurso.Text = Convert.ToString(filaSeleccionada.Cells[0].Value);
                    txtNombreCurso.Text = Convert.ToString(filaSeleccionada.Cells[1].Value);
                    txtPrecio.Text = Convert.ToString(filaSeleccionada.Cells[2].Value);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el curso: " + ex.Message,
                                "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Elimina el curso que e seleccionado en el datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datagCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debes seleccionar una fila completa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var filaSeleccionada = datagCursos.SelectedRows[0];

            
            if (filaSeleccionada.IsNewRow)
            {
                MessageBox.Show("La fila seleccionada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            object valorCelda = filaSeleccionada.Cells[0].Value;
            string codigo_Curso = valorCelda?.ToString();

            if (string.IsNullOrEmpty(codigo_Curso))
            {
                MessageBox.Show("El código del curso está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            DialogResult resultado = MessageBox.Show($"¿Estás seguro de eliminar el curso {codigo_Curso}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                var cursoAEliminar = cursos.FirstOrDefault(c => c["Codigo"]?.ToString() == codigo_Curso);

                if (cursoAEliminar != null)
                { 
                    cursos.Remove(cursoAEliminar);
                    string json = JsonConvert.SerializeObject(cursos, Formatting.Indented);
                    File.WriteAllText(Settings.Default.ListUser, json);
                    datagCursos.Rows.Remove(filaSeleccionada);
                    MessageBox.Show("Curso eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Muestra el Forms para modificar el curso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarCursos modificarCursos = new ModificarCursos(new JObject()
            {
                ["Codigo"] = datagCursos.SelectedRows[0].Cells[0].Value.ToString(),
                ["Nombre"] = datagCursos.SelectedRows[0].Cells[1].Value.ToString(),
                ["Precio"] = datagCursos.SelectedRows[0].Cells[2].Value.ToString(),
            }, datagCursos);
            modificarCursos.ShowDialog();
                

        }


        /// <summary>
        ///  Imprime los cursos en el datagrid
        /// </summary>
        /// <param name="dataCursos"></param>
        /// <param name="cursos"></param>
        internal static void ImprimirListaCursos(DataGridView dataCursos, List<JObject> cursos)
        {
            dataCursos.Rows.Clear();
            foreach (var curso in cursos)
            {
                dataCursos.Rows.Add(curso["Codigo"], curso["Nombre"], curso["Precio"]);
            }
        }
    }
}
