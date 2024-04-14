using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Quintero_
{
    public partial class QuotePrice : Form
    {
        public QuotePrice(DeskQuote quote)
        {
            InitializeComponent();

            lbResCustomerName.Text = quote.NombreCliente;
            lbResDeskWidth.Text = quote.AnchoEscritorio.ToString();
            lbResDeskDepth.Text = quote.ProfundidadEscritorio.ToString();
            lbDeskSurface.Text = (quote.AnchoEscritorio * quote.ProfundidadEscritorio).ToString();
            lbResNumberDrawers.Text = quote.NumCajones.ToString();
            lbResDesktopMaterial.Text = quote.Superficie;
            lbRushOrder.Text = quote.DiasUrgencia.ToString() + " Days";
            lbDate.Text = quote.FechaCotizacion.ToString();
            blPriceDeskSurface.Text = "$ " + quote.PrecioSuperficie.ToString();
            blPriceNumberDrawers.Text = "$ " + quote.PrecioCajones.ToString();
            blPriceDesktopMaterial.Text = "$ " + quote.PrecioMaterial.ToString();
            blPriceRushOrder.Text = "$ " + quote.PrecioUrgencia.ToString();
            lbPriceBase.Text = "$ " +  quote.PrecioBase.ToString();
            blTotalPrice.Text = "$ " +  quote.Total.ToString();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbBasePrice_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
