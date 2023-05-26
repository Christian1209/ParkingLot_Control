using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento
{
    public partial class Ayuda_Login : Form
    {
        public Ayuda_Login()
        {
            InitializeComponent();
        }

        private void button_Ayuda_Correo_Click(object sender, EventArgs e)
        {
            string destinatario = "estacionateoficial@gmail.com";
            string asunto = "Asunto: RECUPERAR CUENTA ";
            string uri = string.Format("mailto:{0}?subject={1}", destinatario, asunto);

            Process.Start(uri);
        }

        private void label1_Ayuda_info2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Ayuda_info1_Click(object sender, EventArgs e)
        {

        }
    }
}
