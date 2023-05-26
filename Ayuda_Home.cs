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
    public partial class Ayuda_Home : Form
    {
        public Ayuda_Home()
        {
            InitializeComponent();
        }

        private void button_Ayuda_Correo_Click(object sender, EventArgs e)
        {
            Ayuda_Home ventanaAyuda = new Ayuda_Home();
            ventanaAyuda.Show();

        }

        private void button_Ayuda_Correo_Click_1(object sender, EventArgs e)
        {
            string destinatario = "estacionateoficial@gmail.com ";
            string asunto = "Asunto: PROBLEMAS CON EL PROGRAMA ";
            string uri = string.Format("mailto:{0}?subject={1}", destinatario, asunto);

            Process.Start(uri);
        }
    }
}
