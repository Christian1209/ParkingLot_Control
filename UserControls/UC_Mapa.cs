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
    public partial class UC_Mapa : UserControl
    {
        PictureBox[] cajones = new PictureBox[20];
        public UC_Mapa()
        {
            InitializeComponent();
            asignaCajones();
            
        }

        public void asignaCajones()
        {
            cajones[0] = pbxCajon1;
            cajones[1] = pbxCajon2;
            cajones[2] = pbxCajon3;
            cajones[3] = pbxCajon4;
            cajones[4] = pbxCajon5;
            cajones[5] = pbxCajon6;
            cajones[6] = pbxCajon7;
            cajones[7] = pbxCajon8;
            cajones[8] = pbxCajon9;
            cajones[9] = pbxCajon10;
            cajones[10] = pbxCajon11;
            cajones[11] = pbxCajon12;
            cajones[12] = pbxCajon13;
            cajones[13] = pbxCajon14;
            cajones[14] = pbxCajon15;
            cajones[15] = pbxCajon16;
            cajones[16] = pbxCajon17;
            cajones[17] = pbxCajon18;
            cajones[18] = pbxCajon19;
            cajones[19] = pbxCajon20;
        }

        public int lugaresDisponibles ()
        {
            int lugares = 0;
           for (int i = 0; i < cajones.Length; i++)
            {
                if(cajones[i].Visible == false && i != 13 && i!= 14 && i != 19 && i != 18 && i!= 1 && i != 2 && i != 3)
                {
                    lugares++;
                }
            }
            return lugares;
        }

        public int lugaresDisponiblesDiscapacitados()
        {
            int lugares = 0;
            for (int i = 0; i < cajones.Length; i++)
            {
                if (cajones[i].Visible == false && (i == 1 || i == 2 || i == 3))
                {
                    lugares++;
                }
            }
            return lugares;
        }

        public int lugaresDisponiblesClientes()
        {
            int lugares = 0;
            for (int i = 0; i < cajones.Length; i++)
            {
                if (cajones[i].Visible == false && (i == 13 || i == 14 || i == 19 || i == 18))
                {
                    lugares++;
                }
            }
            return lugares;
        }

        public int asignaLugar()
        {
            for (int i = 0; i < cajones.Length; i++)
            {
                if (cajones[i].Visible == false && i != 13 && i != 14 && i != 19 && i != 18 && i != 1 && i != 2 && i != 3)
                {
                    cajones[i].Visible = true;
                    return i + 1;
                }
            }
            return 0;
        }

        public void liberaLugar(int lugar)
        {
            for (int i = 0; i < cajones.Length; i++)
            {
                if (i == lugar - 1)
                {
                    cajones[i].Visible = false;
                }
            }
        }

        public int asignaLugarCliente()
        {
            for (int i = 0; i < cajones.Length; i++)
            {
                if (cajones[i].Visible == false && (i == 13 || i == 14 || i == 19 || i == 18))
                {
                    cajones[i].Visible = true;
                    return i + 1;
                }
            }
            return asignaLugar();
        }

        public int asignaLugarDiscapacitado()
        {
            for (int i = 0; i < cajones.Length; i++)
            {
                if (cajones[i].Visible == false && (i == 1 || i == 2 || i == 3))
                {
                    cajones[i].Visible = true;
                    return i + 1;
                }
            }
            return asignaLugar();
        }


    }
}
