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
    public partial class ModificarCursos : Form
    {
        JObject ListaCursos;
        DataGridView dataCursos;
        public ModificarCursos(JObject listacursos,DataGridView dt)
        {
            InitializeComponent();
            ListaCursos = listacursos;
            dataCursos = dt;
        }


        private void ModificarCursos_Load(object sender, EventArgs e)
        {
            txtCodigoMF.Text = ListaCursos["Codigo"]?.ToString();
            txtNombreMF.Text = ListaCursos["Nombre"]?.ToString();
            txtPrecioMF.Text = ListaCursos["Precio"]?.ToString();

            // 1. Extraemos el valor de forma segura
            var recintoValor = ListaCursos["Recinto"];

            // 2. Validamos que no sea nulo antes de agregarlo o seleccionarlo
            if (recintoValor != null)
            {
                string textoRecinto = recintoValor.ToString();

                // Si quieres seleccionar el que ya existe en la lista del Combo:
                cboRecintoMF.Text = textoRecinto;

                // Si realmente necesitas agregarlo a la lista (solo si no es nulo)
                // cboRecintoMF.Items.Add(textoRecinto); 
            }
            else
            {
                // Si es nulo, lo dejamos vacío o seleccionamos un índice neutro
                cboRecintoMF.SelectedIndex = -1;
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult pregnta = MessageBox.Show("¡Desea guardar los cambios?","Confirmar Cambios",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (pregnta == DialogResult.Yes)
            {
                JObject Curso_Encontrado = Cusos.cursos.FirstOrDefault(u => (string)u["Codigo"]?.ToString() == txtCodigoMF.Text);

                if (Curso_Encontrado != null)
                {
                    Curso_Encontrado["Codigo"] = txtCodigoMF.Text;
                    Curso_Encontrado["Nombre"] = txtNombreMF.Text;
                    Curso_Encontrado["Precio"] = txtPrecioMF.Text;
                    Curso_Encontrado["Recinto"] = cboRecintoMF.Text;
                    GuardarCambioCursosJSON(Settings.Default.ListCursos);
                    Cusos.ImprimirListaCursos(dataCursos, Cusos.cursos);
                    this.Close();
                }
            }

        }

        private void GuardarCambioCursosJSON(string listCursos)
        {
          File.WriteAllText(listCursos,JsonConvert.SerializeObject(Cusos.cursos,Formatting.Indented));
        }

        private void ModificarCursos_Shown(object sender, EventArgs e)
        {
            {
                // 1. Obtenemos el valor limpio del JSON
                string valorBuscado = ListaCursos["Recinto"]?.ToString().Trim();

                if (!string.IsNullOrEmpty(valorBuscado))
                {
                    // 2. Limpiamos cualquier selección previa
                    cboRecintoMF.SelectedIndex = -1;

                    // 3. Recorremos los items uno por uno para comparar (Ignorando mayúsculas/minúsculas)
                    for (int i = 0; i < cboRecintoMF.Items.Count; i++)
                    {
                        if (cboRecintoMF.Items[i].ToString().Trim().Equals(valorBuscado, StringComparison.OrdinalIgnoreCase))
                        {
                            cboRecintoMF.SelectedIndex = i;
                            return; // Si lo encuentra, termina aquí
                        }
                    }

                    // 4. Si llegó aquí y no lo encontró en la lista, lo forzamos como texto
                    cboRecintoMF.Text = valorBuscado;
                }
            }
        }
    }
}
