namespace MegaDesk_Quintero_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btnAddNewQuote = new Button();
            Button btnViewQuotes = new Button();
            Button btnSearchQuotes   = new Button();
            Button btnExit = new Button();

            // Asignar propiedades al botón
            btnAddNewQuote.Text = "Add New Quote";
            btnAddNewQuote.Height = 40;
            btnAddNewQuote.Width = 150;
            btnAddNewQuote.Location = new Point(50, 60);
            btnAddNewQuote.Click += new EventHandler(btnAddNewQuote_Click);

            // Asignar propiedades al botón
            btnViewQuotes.Text = "View Quotes";
            btnViewQuotes.Height = 40;
            btnViewQuotes.Width = 150;
            btnViewQuotes.Location = new Point(50, 100);

            btnSearchQuotes.Text = "Search Quotes";
            btnSearchQuotes.Height = 40;
            btnSearchQuotes.Width = 150;
            btnSearchQuotes.Location = new Point(50, 140);

            btnExit.Text = "Exit";
            btnExit.Height = 40;
            btnExit.Width = 150;
            btnExit.Location = new Point(50, 180);
            btnExit.Click += new EventHandler(BtnCloseWindows_Click);
            


            // Agregar el botón al formulario
            this.Controls.Add(btnAddNewQuote);
            this.Controls.Add(btnViewQuotes);
            this.Controls.Add(btnSearchQuotes);
            this.Controls.Add(btnExit);
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            AddCuote formAddCuote = new AddCuote();
            formAddCuote.ShowDialog();
        }

        private void BtnCloseWindows_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }
    }
}
