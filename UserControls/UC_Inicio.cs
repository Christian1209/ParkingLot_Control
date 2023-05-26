using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento.UserControls
{
    public partial class UC_Inicio : UserControl
    {
        //creo un control auxiliar de tipo mapa, para recibir el mapa como parametro y apuntarlo.
        UC_Mapa ucMapaAux = new UC_Mapa();
        UC_Ticket ucTicketAux = new UC_Ticket();
        c_tickets ticket = new c_tickets();
        List<c_tickets> listaDeTicketsPagados = new List<c_tickets>();


        //Costo por hora..
        int costoPorHora = 9;
        int costoPorHoraMoto = 7;
        int costoPorDia = 100;
        int costoPorDiaMoto = 90;
        public double ventas_totales = 0;

        int tester = 0;

        public UC_Inicio(UC_Mapa ucMapa, UC_Ticket ucTicket)
        {
            
            InitializeComponent();
            btnCalculaCobro.Enabled = false;
            btnPagado.Enabled = false;
            btn_verMas.Enabled = false;
            timer1.Tick += Timer1_Tick;
            timer1.Start();


            ucMapaAux = ucMapa;
            ucTicketAux = ucTicket;
            //apunto mi auxiliar al mapa
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //lbl_time_Inicio.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnObtenerTicket_Click(object sender, EventArgs e)
        {

            lblTotal.Text = "$ " + 0.00;
            btnCalculaCobro.Enabled = true;
            btn_verMas.Enabled=true;
            int numericValue;
            string descuento = "N/A";
            bool isNumber = int.TryParse(txt_numeroDeTicket.Text, out numericValue);
            if (isNumber)
            {
                ticket = ucTicketAux.obtenerTicketPorNumero(int.Parse(txt_numeroDeTicket.Text));
                if(ticket.num_ticket == 0)
                {
                    MessageBox.Show("Ticket no encontrado, prueba de nuevo");
                    txt_numeroDeTicket.Clear();
                    return;
                }
                ticket.horaDeSalida = DateTime.Now.ToString("hh:mm:ss");
                lblHoraDeEntrada.Text = ticket.horaDeIngreso;
                lblHoraDeSalida.Text = ticket.horaDeSalida;
                lblTipoDeVehiculo.Text = ticket.tvehiculo;
                if (ticket.dis_terc)
                    descuento = "Discapacidad/Tercera edad";
                if (ticket.client_frec)
                    descuento = "Cliente frecuente";
                lblDescuentoAplicado.Text = descuento;
                lblTipoDeCobro.Text = ticket.pension;
            }
            else
            {
                MessageBox.Show("Introduce un numero!");
                txt_numeroDeTicket.Clear();

            }
        }

        private void btn_verMas_Click(object sender, EventArgs e)
        {
            ucTicketAux.muestraTicket(ticket);
        }

        private void btnCalculaCobro_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas calcular el cobro? \nNo podras volvero a calcular!", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                int costoPorDiaAux = 0;
                int costoPorHoraAux = 0;
                double aux_total = 0;
                double descuento = 0;
                if (ticket.pagado == true)
                {
                    MessageBox.Show("Este ticket ya fue pagado!");
                    btnCalculaCobro.Enabled = false;
                    return;
                }
                if(ticket.tvehiculo == "Moto")
                {
                    costoPorDiaAux = costoPorDiaMoto;
                    costoPorHoraAux = costoPorHoraMoto;
                }
                else
                {
                    costoPorDiaAux = costoPorDia;
                    costoPorHoraAux = costoPorHora;
                }
                var ingreso = Convert.ToDateTime(ticket.horaDeIngreso);
                var salida = Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss"));
                int salidaAux = salida.Hour;
                int ingresoAux = ingreso.Hour;
                if (salida.Hour > 1 && salida.Hour < 9)
                {
                    salidaAux = salidaAux + 12;

                }
                if(ingreso.Hour > 1 && ingreso.Hour < 9)
                {
                    ingresoAux = ingresoAux + 12;
                }
                int duracion = salidaAux - ingresoAux;

                //prueba de pago por dia.
                var diaIngreso = Convert.ToDateTime(ticket.diaDeIngreso);
                var diaSalida = Convert.ToDateTime(DateTime.Now.ToString("d-M-yyyy"));
                TimeSpan dias = diaSalida- diaIngreso;

                if(ticket.pension == "Por día")
                {
                    if (dias.TotalDays == 0 || dias.TotalDays == 1)
                    {
                        ticket.total = costoPorDiaAux;
                    }
                    else
                    {
                        ticket.total = dias.TotalDays * costoPorDiaAux;
                    }

                    aux_total = ticket.total;
                    descuento = aux_total * .10;
                }
                else
                {

                    if (duracion == 0 || duracion == 1)
                    {
                        ticket.total = costoPorHoraAux;
                    }
                    else
                    {
                        ticket.total = duracion * costoPorHoraAux;
                    }

                    aux_total = ticket.total;
                    descuento = aux_total * .10;
                }

                //Redondear hacia abajo

                if (checkBoxSellado.Checked == true || ticket.dis_terc == true || ticket.client_frec == true)
                {
                    ticket.total = aux_total - (descuento);
                    MessageBox.Show("Se aplico un descuento del 10% : " + descuento);
                }
                lblTotal.Text = "$ " + ticket.total;
                btnCalculaCobro.Enabled = false;
                btnPagado.Enabled = true;
            }



            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ticket.pagado = true;
            ucMapaAux.liberaLugar(ticket.lugar);
            ucTicketAux.actualizaLugaresDisponibles();
            MessageBox.Show("Se pago el ticket: " + ticket.num_ticket);


            //ticket.diaDeSalida = DateTime.Now.ToString("d-M-yyyy");

            //aqui para probar

            ticket.diaDeSalida = DateTime.Now.ToString("d-M-yyyy");

            //ticket.diaDeSalida = DateTime.Now.ToString("d-M-yyyy");
            btnPagado.Enabled = false;
            btn_verMas.Enabled = false;
            lblTotal.Text = "$ " + 0.00;
        }
    }
}
