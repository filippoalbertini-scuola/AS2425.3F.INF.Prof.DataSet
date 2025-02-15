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

        private void btnListValues_Click(object sender, EventArgs e)
        {
            if (nNumeri == 0)
            {
                MessageBox.Show("Non ci sono numeri, per favore inseriscili...");
                return;
            }

            // svuota la listbox
            lstResults.Items.Clear();

            // scorri i valori nell'array di numeri
            for (int i = 0; i < nNumeri; i++)
                // scrivili nella listbox
                lstResults.Items.Add(numeri[i]);
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            if (nNumeri == 0)
            {
                MessageBox.Show("Non ci sono numeri, per favore inseriscili...");
                return;
            }

            int somma = 0;

            // scorri i valori nell'array di numeri
            for (int i = 0; i < nNumeri; i++)
                // sommali
                somma += numeri[i];

            // scrivi il risultato
            lstResults.Items.Add($"Media {somma / (double)nNumeri}");
        }

        private void btnMinimum_Click(object sender, EventArgs e)
        {
            if (nNumeri == 0)
            {
                MessageBox.Show("Non ci sono numeri, per favore inseriscili...");
                return;
            }

            int minimo = numeri[0];

            // scorri i valori nell'array di numeri
            for (int i = 1; i < nNumeri; i++)
                if (numeri[i] < minimo)
                    minimo = numeri[i];

            // scrivi il risultato
            lstResults.Items.Add($"Minimo {minimo}");
        }

        private void btnMaximum_Click(object sender, EventArgs e)
        {
            if (nNumeri == 0)
            {
                MessageBox.Show("Non ci sono numeri, per favore inseriscili...");
                return;
            }

            int massimo = numeri[0];

            // scorri i valori nell'array di numeri
            for (int i = 1; i < nNumeri; i++)
                if (numeri[i] > massimo)
                    massimo = numeri[i];

            // scrivi il risultato
            lstResults.Items.Add($"Massimo {massimo}");
        }
    }
}
