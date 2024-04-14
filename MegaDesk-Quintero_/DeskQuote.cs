using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Quintero_
{
    public class DeskQuote
    {
        public string NombreCliente { get; set; }
        public double AnchoEscritorio { get; set; }
        public double ProfundidadEscritorio { get; set; }
        public int NumCajones { get; set; }
        public string Superficie { get; set; }
        public int DiasUrgencia { get; set; }
        public DateTime FechaCotizacion { get; set; }

        public double PrecioBase { get; set; }
        public double PrecioSuperficie { get; set; }
        public double PrecioMaterial { get; set; }
        public double PrecioCajones { get; set; }
        public double PrecioUrgencia { get; set; }
        public double Total { get; set; }

        public enum Material
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

        private readonly double _costoLaminate = 100;
        private readonly double _costoOak = 200;
        private readonly double _costoRosewood = 300;
        private readonly double _costoVeneer = 125;
        private readonly double _costoPine = 50;

        public DeskQuote(string nombreCliente, double anchoEscritorio, double profundidadEscritorio,
            int numCajones, String superficie, int diasUrgencia)
        {
            NombreCliente = nombreCliente;
            AnchoEscritorio = anchoEscritorio;
            ProfundidadEscritorio = profundidadEscritorio;
            NumCajones = numCajones;
            Superficie = superficie;
            DiasUrgencia = diasUrgencia;
            FechaCotizacion = DateTime.Now;

            CalcularPrecioBase();
            CalcularPrecioSuperficie();
            CostoMaterial(Superficie);
            CalcularPrecioCajones();
            CalcularPrecioUrgencia();
            CalcularTotal();
        }

        private void CalcularPrecioBase()
        {
            PrecioBase = 200;
        }

        private void CalcularPrecioSuperficie()
        {
            var answer = (AnchoEscritorio * ProfundidadEscritorio ) - 1000;
            PrecioSuperficie = answer > 0 ? answer : 0;

        }

        private void CostoMaterial(string material)
        {
            

            switch (material)
            {
                case "Laminate":
                    PrecioMaterial = _costoLaminate;
                    break;
                case "Oak":
                    PrecioMaterial = _costoOak;
                    break;
                case "Rosewood":
                    PrecioMaterial = _costoRosewood;
                    break;
                case "Veneer":
                    PrecioMaterial = _costoVeneer;
                    break;
                case "Pine":
                    PrecioMaterial = _costoPine;
                    break;
                default:
                    PrecioMaterial = 0; // Default cost for unhandled materials
                    break;
            }

            
        }


        private void CalcularPrecioCajones()
        {
            PrecioCajones = NumCajones * 50;
        }

        private void CalcularPrecioUrgencia()
        {
            double areaEscritorio = (AnchoEscritorio * ProfundidadEscritorio);
            if (DiasUrgencia == 0)
            {
                PrecioUrgencia = 0;
            }
            else if (DiasUrgencia == 3)
            {
                if (areaEscritorio < 1000)
                {
                    PrecioUrgencia = 60;
                }
                else if (areaEscritorio < 2000)
                {
                    PrecioUrgencia = 70;
                }
                else
                {
                    PrecioUrgencia = 80;
                }
            }
            else if (DiasUrgencia == 5)
            {
                if (areaEscritorio < 1000)
                {
                    PrecioUrgencia = 40;
                }
                else if (areaEscritorio < 2000)
                {
                    PrecioUrgencia = 50;
                }
                else
                {
                    PrecioUrgencia = 60;
                }
            }
            else
            {
                if (areaEscritorio < 1000)
                {
                    PrecioUrgencia = 30;
                }
                else if (areaEscritorio < 2000)
                {
                    PrecioUrgencia = 35;
                }
                else
                {
                    PrecioUrgencia = 40;
                }
            }
        }

        private void CalcularTotal()
        {
            Total = PrecioBase + PrecioSuperficie + PrecioCajones + PrecioMaterial + PrecioUrgencia;
        }
    }

}
