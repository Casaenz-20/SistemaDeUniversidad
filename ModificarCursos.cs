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
            txtCodigoMF.Text = (string)ListaCursos["Codigo"];
            txtNombreMF.Text = (string)ListaCursos["Nombre"];
            txtPrecioMF.Text = (string)ListaCursos["Precio"];
           
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
    }
}
