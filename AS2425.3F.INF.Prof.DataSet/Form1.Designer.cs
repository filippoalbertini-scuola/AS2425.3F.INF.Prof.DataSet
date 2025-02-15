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
            btnAverage = new Button();
            btnMinimum = new Button();
            btnMaximum = new Button();
            btnListValues = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 48);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(127, 45);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(172, 27);
            txtNumero.TabIndex = 1;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(305, 43);
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
            lstResults.Location = new Point(44, 139);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(215, 284);
            lstResults.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 106);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 0;
            label2.Text = "Risultati :";
            // 
            // btnAverage
            // 
            btnAverage.Location = new Point(292, 278);
            btnAverage.Name = "btnAverage";
            btnAverage.Size = new Size(112, 43);
            btnAverage.TabIndex = 4;
            btnAverage.Text = "Media";
            btnAverage.UseVisualStyleBackColor = true;
            // 
            // btnMinimum
            // 
            btnMinimum.Location = new Point(292, 327);
            btnMinimum.Name = "btnMinimum";
            btnMinimum.Size = new Size(112, 43);
            btnMinimum.TabIndex = 4;
            btnMinimum.Text = "Min";
            btnMinimum.UseVisualStyleBackColor = true;
            // 
            // btnMaximum
            // 
            btnMaximum.Location = new Point(292, 376);
            btnMaximum.Name = "btnMaximum";
            btnMaximum.Size = new Size(112, 43);
            btnMaximum.TabIndex = 4;
            btnMaximum.Text = "Max";
            btnMaximum.UseVisualStyleBackColor = true;
            // 
            // btnListValues
            // 
            btnListValues.Location = new Point(292, 139);
            btnListValues.Name = "btnListValues";
            btnListValues.Size = new Size(112, 43);
            btnListValues.TabIndex = 4;
            btnListValues.Text = "Lista valori";
            btnListValues.UseVisualStyleBackColor = true;
            btnListValues.Click += btnListValues_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 452);
            Controls.Add(btnMaximum);
            Controls.Add(btnMinimum);
            Controls.Add(btnListValues);
            Controls.Add(btnAverage);
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
        private Button btnAverage;
        private Button btnMinimum;
        private Button btnMaximum;
        private Button btnListValues;
    }
}
