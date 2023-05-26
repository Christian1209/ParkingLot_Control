using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Estacionamiento
{
    public partial class Login : Form
    {

        public string Empleado;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Login_Usuario.Text == "ADMIN1" && textBox_Login_Contraseña.Text == "ADMIN1")
            {
                Empleado = textBox_Login_Usuario.Text;

                Home ventana1 = new Home(Empleado);

                this.Hide();
                ventana1.Show();
                

            }
            else
            {
                textBox_Login_Usuario.Clear();
                textBox_Login_Contraseña.Clear();
                MessageBox.Show("Datos Incorrectos\nSi tiene problemas contacte con un superior");
            }
            
        }

        private void button_Login_Ayuda_Click(object sender, EventArgs e)
        {
            Ayuda_Login ventanaAyuda = new Ayuda_Login();
            ventanaAyuda.Show();

        }

        private void textBox_Login_Usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
