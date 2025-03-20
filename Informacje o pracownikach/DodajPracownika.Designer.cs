namespace Informacje_o_pracownikach
{
    partial class DodajPracownika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtImie = new TextBox();
            txtWiek = new TextBox();
            txtNazwisko = new TextBox();
            cmbPosition = new ComboBox();
            label4 = new Label();
            btnZatwierdz = new Button();
            btnAnuluj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 70);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 124);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 178);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 2;
            label3.Text = "Wiek";
            // 
            // txtImie
            // 
            txtImie.Location = new Point(155, 67);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(150, 31);
            txtImie.TabIndex = 3;
            // 
            // txtWiek
            // 
            txtWiek.Location = new Point(155, 172);
            txtWiek.Name = "txtWiek";
            txtWiek.Size = new Size(150, 31);
            txtWiek.TabIndex = 4;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(155, 118);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(150, 31);
            txtNazwisko.TabIndex = 5;
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(155, 227);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(150, 33);
            cmbPosition.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 230);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 7;
            label4.Text = "Stanowisko";
            // 
            // btnZatwierdz
            // 
            btnZatwierdz.Location = new Point(155, 321);
            btnZatwierdz.Name = "btnZatwierdz";
            btnZatwierdz.Size = new Size(112, 34);
            btnZatwierdz.TabIndex = 8;
            btnZatwierdz.Text = "Zatwierdź";
            btnZatwierdz.UseVisualStyleBackColor = true;
            btnZatwierdz.Click += btnZatwierdz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(344, 321);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(112, 34);
            btnAnuluj.TabIndex = 9;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // DodajPracownika
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZatwierdz);
            Controls.Add(label4);
            Controls.Add(cmbPosition);
            Controls.Add(txtNazwisko);
            Controls.Add(txtWiek);
            Controls.Add(txtImie);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DodajPracownika";
            Text = "DodajPracownika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtImie;
        private TextBox txtWiek;
        private TextBox txtNazwisko;
        private ComboBox cmbPosition;
        private Label label4;
        private Button btnZatwierdz;
        private Button btnAnuluj;
    }
}