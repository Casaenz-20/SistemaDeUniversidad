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

            datagCursos.Rows.Clear();
            foreach (var curso in cursos)
            {
                datagCursos.Rows.Add(curso["Codigo"], curso["Nombre"], curso["Precio"], curso["Recinto"]);
            }
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
                else
                {
                    
                    JObject nuevoCurso = new JObject
                    {
                        ["Nombre"] = txtNombreCurso.Text,
                        ["Codigo"] = txtCodigoCurso.Text,
                        ["Precio"] = txtPrecio.Text,
                        ["Recinto"] = cboResinto.SelectedItem.ToString()

                    };
                    cursos.Add(nuevoCurso);
                    File.WriteAllText(Settings.Default.ListCursos, JsonConvert.SerializeObject(cursos, Formatting.Indented));
                    MessageBox.Show("Curso guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    datagCursos.Rows.Add(nuevoCurso["Codigo"], nuevoCurso["Nombre"], nuevoCurso["Precio"], nuevoCurso["Recinto"]);
                    LimpiarCampos();
                }
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
                datagCursos.Rows.Add(curso["Codigo"], curso["Nombre"], curso["Precio"], curso["Recinto"]);
            }
        }

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

                    string recinto = Convert.ToString(filaSeleccionada.Cells[3].Value);
                    cboResinto.Text = recinto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el curso: " + ex.Message,
                                "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n_filas_seleccionadas = datagCursos.SelectedRows.Count;
            if(n_filas_seleccionadas <= 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un curso para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
               string codigoCurso = datagCursos.SelectedRows[0].Cells[0].Value.ToString();
                bool EsNull = datagCursos.SelectedRows[0].Cells[0].Value.ToString() == null ? true : false;
                if (EsNull)
                {
                    MessageBox.Show("No es una fila válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar el curso con código " + codigoCurso + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        var cursoAEliminar = cursos.FirstOrDefault(c => c["Codigo"].ToString() == codigoCurso);
                        if (cursoAEliminar != null)
                        {
                            cursos.Remove(cursoAEliminar);
                            File.WriteAllText(Settings.Default.ListCursos, JsonConvert.SerializeObject(cursos, Formatting.Indented));
                            datagCursos.Rows.RemoveAt(datagCursos.SelectedRows[0].Index);
                            MessageBox.Show("Curso eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el curso para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            
        }
    }
}
