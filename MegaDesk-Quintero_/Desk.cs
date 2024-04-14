using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Quintero_
{
    public class Desk
    {
        public double Ancho { get; set; }
        public double Profundidad { get; set; }
        public int NumCajones { get; set; }
        public Material Superficie { get; set; }

        public enum Material
        {
            Madera,
            Metal,
            Cristal,
            Otro
        }

        public Desk(double ancho, double profundidad, int numCajones, Material superficie)
        {
            Ancho = ancho;
            Profundidad = profundidad;
            NumCajones = numCajones;
            Superficie = superficie;
        }
    }

}
