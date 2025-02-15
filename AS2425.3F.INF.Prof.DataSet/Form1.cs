namespace AS2425._3F.INF.Prof.DataSet
{
    public partial class Form1 : Form
    {
        const int N_NUMERI = 10;

        int[] numeri = new int[N_NUMERI];
        int nNumeri = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            // inserisci nel vettore di numeri il numero indicato dall'utente
            numeri[nNumeri] = Convert.ToInt32(txtNumero.Text);
            nNumeri++;
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            int somma = 0;
            for (int i = 0; i < nNumeri; i++)
                somma += numeri[i];
        }
    }
}
