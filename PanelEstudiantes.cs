using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeUniversidad
{
    public partial class PanelEstudiantes : Form
    {
        public PanelEstudiantes()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LoginUser login = new LoginUser();
            login.Show();
            this.Close();
        }

        private void btnVerCursos_Click(object sender, EventArgs e)
        {

        }
    }
}
