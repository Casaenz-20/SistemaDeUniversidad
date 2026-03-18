using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace SistemaDeUniversidad
{
    public partial class RecuperarContra : Form
    {
        List<JObject> usuarios = new List<JObject>();
        public RecuperarContra()
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            //MailMessage correo = new MailMessage();
            //MailMessage();
            //correo.From = new;
            //MailAddress("upa284581@gmail.com");
        }
    }
}
