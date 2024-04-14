namespace MegaDesk_Quintero_
{
    public partial class AddCuote : Form
    {
        public AddCuote()
        {
            InitializeComponent();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void tbCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Customer name must be a text");

            }

        }

        private void tbDeskWidth_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Width must be a number");

            }

        }

        private void tbDeskDepth_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Desk depth must be a number");

            }

        }

        private void TbDeskWidth_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tbDeskWidth.Text))
            {
                int number = int.Parse(tbDeskWidth.Text);

                if (number < 24 || number > 96)
                {
                    MessageBox.Show("Please enter a number between 24 and 96.");
                }
            }



        }

        private void tbDeskDepth_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbDeskDepth.Text))
            {
                int number = int.Parse(tbDeskDepth.Text);

                if (number < 12 || number > 48)
                {
                    MessageBox.Show("Please enter a number between 12 and 48.");
                }
            }
        }


        public static int ConvertirStringToNumero(string valorString)
        {
            switch (valorString.ToLower())
            {
                case "none":
                    return 0;
                case "3 days":
                    return 3;
                case "5 days":
                    return 5;
                case "7 days":
                    return 7;
                default:
                    // Si no se encuentra una coincidencia, devuelve 0
                    return 0;
            }
        }

        public void LimpiarCampos()
        {
            tbCustomerName.Text = "";
            tbDeskWidth.Text = "";
            tbDeskDepth.Text = "";
            
            cbNumberDrawers.SelectedIndex = -1;
            cbDesktopMaterial.SelectedIndex = -1;
            cbRushOrder.SelectedIndex = -1;

        }



        private void txtSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCustomerName.Text) || string.IsNullOrEmpty(tbDeskWidth.Text) || string.IsNullOrEmpty(tbDeskDepth.Text))
            {
                MessageBox.Show("Please complete all required fields");
                return;
            }

            if (cbNumberDrawers.SelectedIndex == -1 || cbDesktopMaterial.SelectedIndex == -1 || cbRushOrder.SelectedIndex == -1)
            {
                MessageBox.Show("Please select all required data from the lists");
                return;
            }

            MessageBox.Show("Validation succeeded !!");
            DeskQuote quote = new DeskQuote(tbCustomerName.Text, Convert.ToDouble(tbDeskWidth.Text), Convert.ToDouble(tbDeskDepth.Text), int.Parse(cbNumberDrawers.SelectedItem.ToString()), cbDesktopMaterial.SelectedItem.ToString(), ConvertirStringToNumero(cbRushOrder.SelectedItem.ToString()));

            // aqui se hace el proceso...
            QuotePrice formQuotePrice = new QuotePrice(quote);
            LimpiarCampos();
            formQuotePrice.Show();
        }

        private void tbCustomerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
