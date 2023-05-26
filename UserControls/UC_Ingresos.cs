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
    public partial class UC_Ingresos : UserControl
    {
        UC_Ticket ucTicketAux = new UC_Ticket();

        //lista de gastos
        List<Gastos> listaDeGastos = new List<Gastos>();

        public UC_Ingresos(UC_Ticket ucTicket)
        {
            InitializeComponent();
            ucTicketAux = ucTicket;
        }

        public class Gastos
        {
            public double total = 0;
            public string fecha = "";
            public string nombre = "";
            public Gastos()
            {

            }
            public Gastos(double total,  string fecha, string nombre)
            {
                this.total = total; 
                this.fecha = fecha;
                this.nombre = nombre;
            }
        }
        

        private void btIngresosHoy_Click(object sender, EventArgs e)
        {
            int carrosHoy = 0;
            double ingresosHoy = 0;
            double gastosHoy = 0;
            carrosHoy = ucTicketAux.obtenerCarrosDiarios();
            ingresosHoy = ucTicketAux.obtenerIngresosDiarios();
            gastosHoy = obtenerGastosDiarios();
            double total = ingresosHoy - gastosHoy;
            string mensaje_ingresos = "Vehiculos pagados hoy: " + carrosHoy + "\n" + "Ingresos de hoy: " + ingresosHoy + "\n" + "Gastos de hoy: " + gastosHoy + "\n" + "Total de hoy: " + total;
            MessageBox.Show(mensaje_ingresos);

        }

        private void btnIngresarGasto_Click(object sender, EventArgs e)
        {
            double gastoTotal = double.Parse(txtBoxCostoGasto.Text);
            string gastoNombre = txtBoxNombreGasto.Text;
            var hoy = DateTime.Now.ToString("d-M-yyyy");
            Gastos gasto = new Gastos(gastoTotal, hoy, gastoNombre);
            listaDeGastos.Add(gasto);
            txtBoxNombreGasto.Clear();
            txtBoxCostoGasto.Clear();
        }

        public double obtenerGastosDiarios()
        {
            var hoy = Convert.ToDateTime(DateTime.Now.ToString("d-M-yyyy"));
            double gastos = 0;
            for (int i = 0; i < listaDeGastos.Count(); i++)
            {
                var diaSalida = Convert.ToDateTime(listaDeGastos[i].fecha);
                if (hoy.Day == diaSalida.Day)
                {
                    gastos = gastos + listaDeGastos[i].total;
                }
            }
            return gastos;
        }

        public double obtenerGastosMensuales()
        {
            var mes = Convert.ToDateTime(DateTime.Now.ToString("d-M-yyyy"));
            double gastos = 0;
            for (int i = 0; i < listaDeGastos.Count(); i++)
            {
                var diaSalida = Convert.ToDateTime(listaDeGastos[i].fecha);
                if (mes.Month == diaSalida.Month)
                {
                    gastos = gastos + listaDeGastos[i].total;
                }
            }
            return gastos;
        }

        private void btnIngresosMes_Click(object sender, EventArgs e)
        {
            int carrosHoy = 0;
            double ingresosHoy = 0;
            double gastosHoy = 0;
            carrosHoy = ucTicketAux.obtenerCarrosMensuales();
            ingresosHoy = ucTicketAux.obtenerIngresosMensuales();
            gastosHoy = obtenerGastosDiarios();
            double total = ingresosHoy - gastosHoy;
            string mensaje_ingresos = "Vehiculos pagados este mes: " + carrosHoy + "\n" + "Ingresos del mes: " + ingresosHoy + "\n" + "Gastos del mes: " + gastosHoy + "\n" + "Total del mes: " + total;
            MessageBox.Show(mensaje_ingresos);
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            int test = 0;
            int promedio9a = ucTicketAux.obtenerIngresosHora(9);
            int promedio10a = ucTicketAux.obtenerIngresosHora(10);
            int promedio11a = ucTicketAux.obtenerIngresosHora(11);
            int promedio12p = ucTicketAux.obtenerIngresosHora(12);
            int promedio1p = ucTicketAux.obtenerIngresosHora(1);
            int promedio2p = ucTicketAux.obtenerIngresosHora(2);
            int promedio3p = ucTicketAux.obtenerIngresosHora(3);
            int promedio4p = ucTicketAux.obtenerIngresosHora(4);
            int promedio5p = ucTicketAux.obtenerIngresosHora(5);
            int promedio6p = ucTicketAux.obtenerIngresosHora(6);
            int promedio7p = ucTicketAux.obtenerIngresosHora(7);
            int promedio8p = ucTicketAux.obtenerIngresosHora(8);
            int total = ucTicketAux.obtenerIngresosTotales();
            promedio9a = (promedio9a * 100) / total;
            promedio10a = (promedio10a * 100) / total;
            promedio11a = (promedio11a * 100) / total;
            promedio12p = (promedio12p * 100) / total;
            promedio1p = (promedio1p * 100) / total;
            promedio2p = (promedio2p * 100) / total;
            promedio3p = (promedio3p * 100) / total;
            promedio4p = (promedio4p * 100) / total;
            promedio5p = (promedio5p * 100) / total;
            promedio6p = (promedio6p * 100) / total;
            promedio7p = (promedio7p * 100) / total;
            promedio8p = (promedio8p * 100) / total;
            string mensaje_estadisticas1 = "Porcentaje de las 9am: " + promedio9a + "%\n" + "Porcentaje de las 10am: " + promedio10a + "%\n" + "Porcentaje de las 11am: " + promedio11a + "%\n";
            string mensaje_estadisticas2 = "Porcentaje de las 12pm: " + promedio12p + "%\n" + "Porcentaje de la 1pm: " + promedio1p + "%\n" + "Porcentaje de las 2pm: " + promedio2p + "%\n";
            string mensaje_estadisticas3 = "Porcentaje de las 3pm: " + promedio3p + "%\n" + "Porcentaje de la 4pm: " + promedio4p + "%\n" + "Porcentaje de las 5pm: " + promedio5p + "%\n";
            string mensaje_estadisticas4 = "Porcentaje de las 6pm: " + promedio6p + "%\n" + "Porcentaje de la 7pm: " + promedio7p + "%\n" + "Porcentaje de las 8pm: " + promedio8p + "%\n";
            MessageBox.Show(mensaje_estadisticas1 + mensaje_estadisticas2 + mensaje_estadisticas3 + mensaje_estadisticas4);
            //6 x 100 entre total

        }
    }
}
