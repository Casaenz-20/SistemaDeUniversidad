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
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace SistemaDeUniversidad
{
    public partial class AdministrarUsuarios : Form
    {
        public static List<JObject> usuarios = new List<JObject>();
        public AdministrarUsuarios()
        {
            InitializeComponent();
        }

        private void AdministrarUsuarios_Load(object sender, EventArgs e)
        {
            if (!ArchivoExiste(Settings.Default.ListUser))
            {
                CrearArchivo(Settings.Default.ListUser);
            }
            usuarios = LeerUsuarios(Settings.Default.ListUser);
            datagridUsuarios.Rows.Clear();
            ImprrimirListaUser(datagridUsuarios, usuarios);
        }

        public static void ImprrimirListaUser(Guna2DataGridView datagridUsuarios, List<JObject> usuarios)
        {
          datagridUsuarios.Rows.Clear();
            foreach (var usuario in usuarios)
            {
                datagridUsuarios.Rows.Add(usuario["ID"], usuario["Usuario"], usuario["FechaNacimiento"], usuario["Correo"], usuario["TipoUsuario"]);
            }
        }

        public static List<JObject> LeerUsuarios(string listUser)
        {
            string contenido_usuario_tex = System.IO.File.ReadAllText(listUser);
            return JsonConvert.DeserializeObject<List<JObject>>(contenido_usuario_tex) ?? new List<JObject>();
        }

        private void CrearArchivo(string listUser)
        {
            System.IO.File.WriteAllText(listUser, "[]");
        }

        private Func<string, bool> ArchivoExiste = (ruta) => System.IO.File.Exists(ruta);
       

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            var filtro = txtCedula.Text.Trim();
            var usuariosFiltrados = usuarios.Where(u => u["ID"].ToString().Contains(filtro)).ToList();
            datagridUsuarios.Rows.Clear();
            foreach (var usuario in usuariosFiltrados)
            {
                datagridUsuarios.Rows.Add(usuario["ID"], usuario["Usuario"], usuario["Correo"], usuario["FechaNacimiento"], usuario["TipoUsuario"]);
            }
        }

        private void datagridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow fila = datagridUsuarios.Rows[e.RowIndex];


                    txtCedula.Text = Convert.ToString(fila.Cells[0].Value);
                    txtUsuario.Text = Convert.ToString(fila.Cells[1].Value);
                    txtCorreo.Text = Convert.ToString(fila.Cells[3].Value);


                    string tipoUsuario = Convert.ToString(fila.Cells[4].Value);
                    cboxRol.SelectedIndex = cboxRol.FindStringExact(tipoUsuario);


                    if (DateTime.TryParse(Convert.ToString(fila.Cells[2].Value), out DateTime fecha))
                    {
                        mskFechaPersona.Text = fecha.ToString("yyyy/MM/dd");
                    }


                    if (EstaActivo())
                    {
                        chkEstado.Checked = true;
                    }
                    else
                    {
                        chkEstado.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de seleccion" + ex.Message,"Error");
            }
        }

        private bool EstaActivo()
        {
            bool CuentaActiva = usuarios.Any(u => u["Usuario"].ToString() == txtUsuario.Text && u["Activo"].ToObject<bool>() == true);
            return CuentaActiva;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n_filas_seleccionadas = datagridUsuarios.SelectedColumns.Count;
            if (n_filas_seleccionadas <= 0)
            {
                MessageBox.Show("Debes de seleccionar una fila");
            }
            else
            {
                if (datagridUsuarios.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("No es una fila valida");
                }
                else
                {
                    string cedula_Persona = datagridUsuarios.SelectedRows[0].Cells[0].Value.ToString();
                    bool EsNull = datagridUsuarios.SelectedRows[0].Cells[0].Value.ToString() == null ? true : false;
                    if(EsNull)
                    {
                        MessageBox.Show("No es una fila valida");
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar el usuario con cédula " + cedula_Persona + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (resultado == DialogResult.Yes)
                        {
                            var usuarioAEliminar = usuarios.FirstOrDefault(u => u["ID"].ToString() == cedula_Persona);
                            if (usuarioAEliminar != null)
                            {
                                usuarios.Remove(usuarioAEliminar);
                                File.WriteAllText(Settings.Default.ListUser, JsonConvert.SerializeObject(usuarios, Formatting.Indented));
                                datagridUsuarios.Rows.RemoveAt(datagridUsuarios.SelectedRows[0].Index);
                                MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el usuario a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarUser modificarUser = new ModificarUser(new JObject()
            {
                ["ID"] = datagridUsuarios.SelectedRows[0].Cells[0].Value.ToString(),
                ["Usuario"] = datagridUsuarios.SelectedRows[0].Cells[1].Value.ToString(),
                ["FechaNacimiento"] = datagridUsuarios.SelectedRows[0].Cells[2].Value.ToString(),
                ["Correo"] = datagridUsuarios.SelectedRows[0].Cells[3].Value.ToString(),
                ["TipoUsuario"] = datagridUsuarios.SelectedRows[0].Cells[4].Value.ToString(),
                ["Activo"] = EstaActivo(),
                ["Contraseña"] = usuarios.FirstOrDefault(u => u["ID"].ToString() == datagridUsuarios.SelectedRows[0].Cells[0].Value.ToString())?["Contraseña"]?.ToString() ?? ""
            }, datagridUsuarios);
               modificarUser.ShowDialog();
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
