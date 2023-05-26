using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Estacionamiento
{
    public class c_tickets
    {
        public int num_ticket { get; set; }
        public string placas { get; set; }
        
        public string horaDeIngreso { get; set; }
        public string horaDeSalida { get; set; }
        public string diaDeIngreso { get; set; }
        public string diaDeSalida { get; set; }
        public string tvehiculo { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public bool dis_terc { get; set; }
        public bool client_frec { get; set; }
        public string estado { get; set; }
        public int lugar { get; set; }
        public string pension { get; set; }
        public bool pagado   { get; set; }
        public double total { get; set; }
        public int lugarAsignado { get; set; }

 
        public c_tickets(int num_ticket,string placas, string tvehiculo, string marca, string color, bool dis_terc, bool client_frec, string estado, int lugar, string pension, string horaDeIngreso, string horaDeSalida, string diaDeIngreso, string diaDeSalida)
        {
            this.num_ticket = num_ticket;
            this.horaDeIngreso = horaDeIngreso;
            this.horaDeSalida = horaDeSalida;
            this.placas = placas;
            this.tvehiculo = tvehiculo;
            this.marca = marca;
            this.color = color;
            this.dis_terc = dis_terc;
            this.client_frec = client_frec;
            this.estado = estado;
            this.lugar = lugar;
            this.pension = pension;
            pagado = false;
            total = 9;
            this.diaDeIngreso = diaDeIngreso;
            this.diaDeSalida = diaDeSalida;
 
        }

        public c_tickets()
        {
            this.num_ticket = 0;
            this.horaDeIngreso = "no aun";
            this.horaDeSalida = "";
            this.placas = "";
            this.tvehiculo = "";
            this.marca = "";
            this.color = "";
            this.dis_terc = false;
            this.client_frec = false;
            this.estado = "JAL";
            this.lugar = 0;
            this.pension = "...";
            pagado = false;
            total = 9;
            lugarAsignado = 0;
            diaDeIngreso = "";
            diaDeSalida = "";
        }
    }

}
