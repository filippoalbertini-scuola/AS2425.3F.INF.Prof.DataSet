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

        /// <summary>
        /// List all values inside the ListBox
        /// </summary>
        private void listValues()
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

        /// <summary>
        /// Compute average on DataSet
        /// </summary>
        private void average()
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

            // calcola la media e arrotondala a 2 decimali
            double media = Math.Round(somma / (double)nNumeri,2);

            // scrivi il risultato
            lstResults.Items.Add($"Media {media}");
        }

        /// <summary>
        /// Calculate minimum value on dataset
        /// </summary>
        private void minimum()
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

        /// <summary>
        /// Calculate maximum value on dataset
        /// </summary>
        private void maximum()
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

        private void btnResults_Click(object sender, EventArgs e)
        {
            switch (cmbActions.Text.ToUpper())
            {
                case "LISTA VALORI":
                    listValues();
                    break;
                case "MINIMO":
                    minimum();
                    break;
                case "MASSIMO":
                    maximum();
                    break;
                case "MEDIA":
                    average();
                    break;
            }
        }
    }
}
