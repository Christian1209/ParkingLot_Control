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
    public partial class UC_Ticket : UserControl
    {
        string[] marcas_carro = new string[] {"Audi", "BMW", "Chevrolet", "Chrysler", "Dodge", "Ford", "Honda", "Hyundai", "Jeep", "Kia", "Lexus", "Mazda", "Mercedes-Benz", "Nissan", "Porsche", "Subaru", "Toyota", "Volkswagen", "Volvo"};
        string[] marcas_moto = new string[] { "Aprilia", "BMW", "Ducati", "Harley-Davidson", "Honda", "Indian", "Kawasaki", "KTM", "Suzuki", "Triumph", "Yamaha" };
        string[] marcas_camioneta = new string[] { "Chevrolet", "Dodge", "Ford", "GMC", "Jeep", "Nissan", "Ram", "Toyota" };
        //creo un control auxiliar de tipo mapa, para recibir el mapa como parametro y apuntarlo.
        UC_Mapa ucMapaAux = new UC_Mapa();
        int ntickets = 10;

        //lista de tickets.
        List<c_tickets> listaDeTickets = new List<c_tickets>();

        
        public UC_Ticket(UC_Mapa ucMapa)
        {
            InitializeComponent();
            txt_placas.MaxLength = 7;
            marca_vehiculo.Enabled = false;
            ucMapaAux = ucMapa;
            preCargaDatos();
            actualizaLugaresDisponibles();
        }


        public UC_Ticket()
        {
            InitializeComponent();
        }

        public void preCargaDatos()
        {
            obtenLugarAsignado(false, false);
            c_tickets ticketAux = new c_tickets(1, "JW-60-261", "Carro", "Audi", "rojo", false, false, "JALISCO", Int32.Parse(lblLugarAsignado.Text), "Por hora", "09:12:03", "", "23-05-2023", "");
            listaDeTickets.Add(ticketAux);
            obtenLugarAsignado(false, false);
            ticketAux = new c_tickets(2, "KW-60-261", "Moto", "Italika", "Azul", false, false, "Foraneo", Int32.Parse(lblLugarAsignado.Text), "Por hora", "11:12:03", "", "23-05-2023", "");
            listaDeTickets.Add(ticketAux);
            obtenLugarAsignado(false, true);
            ticketAux = new c_tickets(3, "PW-60-261", "Carro", "Dodge", "Gris", true, false, "JALISCO", Int32.Parse(lblLugarAsignado.Text), "Por día", "12:12:03", "", "19-05-2023", "");
            listaDeTickets.Add(ticketAux);
            obtenLugarAsignado(true, false);
            ticketAux = new c_tickets(4, "JW-60-261", "Carro", "Chevrolet", "Gris", false, true, "JALISCO", Int32.Parse(lblLugarAsignado.Text), "Por día", "01:12:03", "", "15-05-2023", "");
            listaDeTickets.Add(ticketAux);
            obtenLugarAsignado(false, false);
            ticketAux = new c_tickets(5, "KW-60-261", "Carro", "Chevrolet", "Gris", false, false, "Foraneo", Int32.Parse(lblLugarAsignado.Text), "Por hora", "3:12:03", "", "23-05-2023", "");
            listaDeTickets.Add(ticketAux);
        }
        public void actualizaLugaresDisponibles()
        {
            lblLugaresDisponiblesCliente.Text = ucMapaAux.lugaresDisponiblesClientes().ToString();
            lblLugaresDisponibles.Text = ucMapaAux.lugaresDisponibles().ToString();
            lblLugaresDisponiblesDiscapacitados.Text = ucMapaAux.lugaresDisponiblesDiscapacitados().ToString();
        }

        private void btnGeneraTicket_Click(object sender, EventArgs e)
        {
            if(txt_placas.Text != "" && tipo_vehiculo.SelectedIndex >=0 && marca_vehiculo.SelectedIndex >=0 && color_vehiculo.SelectedIndex >=0 && (btn_cliente_frec.Checked == true || btn_dis_terc.Checked == true || btn_na.Checked == true))
            {
                
                obtenLugarAsignado(btn_cliente_frec.Checked, btn_dis_terc.Checked);
                if (int.Parse(lblLugarAsignado.Text) == 0)
                {
                    MessageBox.Show("Estacionamiento lleno, espera a que un cliente abandone el lugar");
                    limpiaCasillas();
                    return;
                }
                string horaDeIngreso = DateTime.Now.ToString("hh:mm:ss");
                string horaDeSalida = "...";
                ntickets++;
                string pension = "";
                pension = transformaPension(checkBoxPension.Checked);

                string diaDeIngreso = DateTime.Now.ToString("d-M-yyyy");
                string diaDeSalida = "...";
                string estado = "";
                if (sonDeJalisco())
                {
                     estado = "JALISCO";
                }
                else
                {
                    estado = "FORANEO";
                }


                c_tickets ticket = new c_tickets(ntickets, txt_placas.Text, tipo_vehiculo.Text , marca_vehiculo.Text, color_vehiculo.Text, btn_dis_terc.Checked, btn_cliente_frec.Checked, estado, Int32.Parse(lblLugarAsignado.Text), pension, horaDeIngreso,horaDeSalida, diaDeIngreso, "");

                //se añade ticket
                listaDeTickets.Add(ticket);
                muestraTicket(ticket);


                limpiaCasillas();
            }
            else
            {
                MessageBox.Show("Ticket incompleto, Rellene las casillas!!");
            }

        }

        public bool sonDeJalisco()
        {
            string aux = txt_placas.Text[0].ToString();
            if (aux == "J" || aux == "j") 
                return true;
            return false;
        }

        public void muestraTicket(c_tickets ticket)
        {
            string frecuente = "NO";
            string discapacitado = "NO";

            if (ticket.client_frec == true)
                frecuente = "SI";

            if (ticket.dis_terc == true)
                discapacitado = "SI";

            string mensaje_ticket = "Numero de Ticket: " + ticket.num_ticket + "\n" + "Dia de ingreso: " + ticket.diaDeIngreso + "\n" + "Hora de ingreso: " + ticket.horaDeIngreso + "\n" + "Placas: " + ticket.placas.ToUpper() + "\n" + "Tipo de Vehiculo: " + ticket.tvehiculo + "\n" + "Marca: " + ticket.marca + "\n" + "Color: " + ticket.tvehiculo + "\n" + "Discapacidad/Tercera edad: " + discapacitado + "\n" + "Cliente frecuente: " + frecuente + "\n" + "Estado: " + ticket.estado + "\n" + "Lugar: " + ticket.lugar + "\n" + "Tipo de cobro: " + ticket.pension + "\n";

            MessageBox.Show(mensaje_ticket);
        }
        public string transformaPension(bool pension)
        {
            if (pension)
                return "Por día";
            return "Por hora";
        }
        public c_tickets obtenerTicketPorNumero(int numeroDeTicket)
        {
            c_tickets auxiliar = new c_tickets();
            for (int i = 0; i < listaDeTickets.Count(); i++)
            {
                if (listaDeTickets[i].num_ticket == numeroDeTicket)
                    auxiliar = listaDeTickets[i];
            }
            return auxiliar;
        }

        public double obtenerIngresosDiarios()
        {
            var hoy = Convert.ToDateTime(DateTime.Now.ToString("d-M-yyyy"));
            double ingresos = 0;
            for (int i = 0; i < listaDeTickets.Count(); i++)
            {
                if (listaDeTickets[i].pagado)
                {
                    var diaSalida = Convert.ToDateTime(listaDeTickets[i].diaDeSalida);
                    if (hoy.Day == diaSalida.Day)
                    {
                        ingresos = ingresos + listaDeTickets[i].total;
                    }
                }
            }
            return ingresos;
        }

        public int obtenerCarrosDiarios()
        {
            var hoy = Convert.ToDateTime(DateTime.Now.ToString("d-M-yyyy"));
            int carros = 0;
            for (int i = 0; i < listaDeTickets.Count(); i++)
            {
                if (listaDeTickets[i].pagado)
                {
                    var diaSalida = Convert.ToDateTime(listaDeTickets[i].diaDeSalida);
                    if (hoy.Day == diaSalida.Day)
                    {
                        carros = carros + 1;
                    }
                }
            }

            return carros;
        }



        public int obtenerCarrosMensuales()
        {
            var mes = Convert.ToDateTime(DateTime.Now.ToString("d-M-yyyy"));
            int carros = 0;
            for (int i = 0; i < listaDeTickets.Count(); i++)
            {
                if (listaDeTickets[i].pagado)
                {
                    var mesTicket = Convert.ToDateTime(listaDeTickets[i].diaDeSalida);
                    if (mes.Month == mesTicket.Month)
                    {
                        carros = carros + 1;
                    }
                }
            }

            return carros;
        }

        public double obtenerIngresosMensuales()
        {
            var mes = Convert.ToDateTime(DateTime.Now.ToString("d-M-yyyy"));
            double ingresos = 0;
            for (int i = 0; i < listaDeTickets.Count(); i++)
            {
                if (listaDeTickets[i].pagado)
                {
                    var mesTicket = Convert.ToDateTime(listaDeTickets[i].diaDeSalida);
                    if (mes.Month == mesTicket.Month)
                    {
                        ingresos = ingresos + listaDeTickets[i].total;
                    }
                }
            }
            return ingresos;
        }

        public int obtenerIngresosHora(int hour)
        {
            int contador = 0;
            for (int i = 0; i < listaDeTickets.Count(); i++)
            {
                var horaTicket = Convert.ToDateTime(listaDeTickets[i].horaDeIngreso);
                if (horaTicket.Hour == hour)
                {
                    contador++;
                }
            }
            return contador;
        }

        public int obtenerIngresosTotales()
        {
            return listaDeTickets.Count();
        }


        public void limpiaCasillas()
        {
            txt_placas.Clear();
            tipo_vehiculo.SelectedIndex = -1;
            marca_vehiculo.SelectedIndex = -1;
            color_vehiculo.SelectedIndex = -1;
            btn_cliente_frec.Checked = false;
            btn_dis_terc.Checked = false;
            btn_na.Checked = false;
            checkBoxPension.Checked = false;
        }

        public void obtenLugarAsignado(bool cliente_frec, bool discapacitado)
        {
            if(cliente_frec)
                lblLugarAsignado.Text = ucMapaAux.asignaLugarCliente().ToString();
            if(discapacitado)
                lblLugarAsignado.Text = ucMapaAux.asignaLugarDiscapacitado().ToString();
            if(!discapacitado && !cliente_frec)
                lblLugarAsignado.Text = ucMapaAux.asignaLugar().ToString();
            actualizaLugaresDisponibles();

        }

        private void tipo_vehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            marca_vehiculo.Items.Clear();
            if (tipo_vehiculo.SelectedIndex >= 0) marca_vehiculo.Enabled = true;
            if (tipo_vehiculo.SelectedIndex == 0) marca_vehiculo.Items.AddRange(marcas_carro);
            if (tipo_vehiculo.SelectedIndex == 1) marca_vehiculo.Items.AddRange(marcas_moto);
            if (tipo_vehiculo.SelectedIndex == 2) marca_vehiculo.Items.AddRange(marcas_camioneta);
        }
    }
}
