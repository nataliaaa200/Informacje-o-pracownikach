namespace Informacje_o_pracownikach
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
            dataGridViewEmployees = new DataGridView();
            btnDodaj = new Button();
            btnUsuń = new Button();
            btnZapiszDoCsv = new Button();
            btnCzytajZCsv = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(170, 62);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowHeadersWidth = 62;
            dataGridViewEmployees.Size = new Size(360, 225);
            dataGridViewEmployees.TabIndex = 0;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(608, 62);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(112, 34);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnUsuń
            // 
            btnUsuń.Location = new Point(608, 141);
            btnUsuń.Name = "btnUsuń";
            btnUsuń.Size = new Size(112, 34);
            btnUsuń.TabIndex = 2;
            btnUsuń.Text = "Usuń";
            btnUsuń.UseVisualStyleBackColor = true;
            btnUsuń.Click += btnUsuń_Click;
            // 
            // btnZapiszDoCsv
            // 
            btnZapiszDoCsv.Location = new Point(170, 323);
            btnZapiszDoCsv.Name = "btnZapiszDoCsv";
            btnZapiszDoCsv.Size = new Size(148, 42);
            btnZapiszDoCsv.TabIndex = 3;
            btnZapiszDoCsv.Text = "Zapis do .csv";
            btnZapiszDoCsv.UseVisualStyleBackColor = true;
            btnZapiszDoCsv.Click += btnZapiszDoCsv_Click;
            // 
            // btnCzytajZCsv
            // 
            btnCzytajZCsv.Location = new Point(381, 323);
            btnCzytajZCsv.Name = "btnCzytajZCsv";
            btnCzytajZCsv.Size = new Size(149, 42);
            btnCzytajZCsv.TabIndex = 4;
            btnCzytajZCsv.Text = "Odczyt z .csv";
            btnCzytajZCsv.UseVisualStyleBackColor = true;
            btnCzytajZCsv.Click += btnCzytajZCsv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCzytajZCsv);
            Controls.Add(btnZapiszDoCsv);
            Controls.Add(btnUsuń);
            Controls.Add(btnDodaj);
            Controls.Add(dataGridViewEmployees);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEmployees;
        private Button btnDodaj;
        private Button btnUsuń;
        private Button btnZapiszDoCsv;
        private Button btnCzytajZCsv;
    }
}
