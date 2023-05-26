using Estacionamiento.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Estacionamiento
{

    public partial class Home : Form
    {
        //se inicializan dos controles para tenerlos globales.
        UC_Inicio ucInicio;
        UC_Mapa ucMapa;
        UC_Ticket ucTicket;
        UC_Ingresos ucIngresos;

        private Point mouse_offset;
        public Home(string txt)
        {
            InitializeComponent();
            lbl_empleado.Text = txt;
            time_picker.Format = DateTimePickerFormat.Custom;
            time_picker.CustomFormat = "dd/MM/yyyy";
            time_picker.Value = DateTime.Now;

            ucMapa = new UC_Mapa();
            ucTicket = new UC_Ticket(ucMapa);
            ucInicio = new UC_Inicio(ucMapa, ucTicket);
            ucIngresos = new UC_Ingresos(ucTicket);
            //se crean los controladores, y a inicio le mando el mapa para la comunicación.

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        //-------------------------------------


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void inicioButton_Click(object sender, EventArgs e)
        {

            addUserControl(ucInicio);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btn_mapa_Click(object sender, EventArgs e)
        {

            addUserControl(ucMapa);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Ayuda_Home ventanaAyuda = new Ayuda_Home();
            ventanaAyuda.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            addUserControl(ucTicket);
        }
        //Funciones para poder mover el form////////////
        private void Home_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                this.Location = mousePos; //move the form to the desired location
            }
        }

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                this.Location = mousePos; //move the form to the desired location
            }
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            addUserControl(ucIngresos);
        }

        private void lbl_empleado_Click(object sender, EventArgs e)
        {

        }
        //Funciones para poder mover el form/////////////
    }
}
