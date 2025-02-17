namespace AS2425._3F.INF.Prof.DataSet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNumero = new TextBox();
            btnAggiungi = new Button();
            lstResults = new ListBox();
            label2 = new Label();
            cmbActions = new ComboBox();
            btnResults = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 31);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(128, 28);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(172, 27);
            txtNumero.TabIndex = 1;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(306, 26);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(82, 29);
            btnAggiungi.TabIndex = 2;
            btnAggiungi.Text = "Add";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // lstResults
            // 
            lstResults.FormattingEnabled = true;
            lstResults.Location = new Point(78, 134);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(300, 284);
            lstResults.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 101);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 0;
            label2.Text = "Operazioni:";
            // 
            // cmbActions
            // 
            cmbActions.FormattingEnabled = true;
            cmbActions.Items.AddRange(new object[] { "Lista valori", "Media", "Minimo", "Massimo" });
            cmbActions.Location = new Point(173, 97);
            cmbActions.Name = "cmbActions";
            cmbActions.Size = new Size(151, 28);
            cmbActions.TabIndex = 5;
            // 
            // btnResults
            // 
            btnResults.Location = new Point(333, 98);
            btnResults.Name = "btnResults";
            btnResults.Size = new Size(45, 29);
            btnResults.TabIndex = 6;
            btnResults.Text = "...";
            btnResults.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 451);
            Controls.Add(btnResults);
            Controls.Add(cmbActions);
            Controls.Add(lstResults);
            Controls.Add(btnAggiungi);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Prof;Lab 2.12; 15/02/25;Gestione data set";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnAggiungi;
        private ListBox lstResults;
        private Label label2;
        private ComboBox cmbActions;
        private Button btnResults;
    }
}
