using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informacje_o_pracownikach
{
    public partial class DodajPracownika : Form
    {
        public Pracownik Pracownik { get; private set; }
        public DodajPracownika(int id)
        {
            InitializeComponent();
            Pracownik = new Pracownik { Id = id };
            cmbPosition.Items.AddRange(new[] { "Manager", "Developer", "Tester" });
        }

        private void btnZatwierdz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImie.Text) ||
                string.IsNullOrWhiteSpace(txtNazwisko.Text) ||
                !int.TryParse(txtWiek.Text, out int age) ||
                cmbPosition.SelectedItem == null)
            {
                MessageBox.Show("Proszę uzupełnić wszystkie pola.");
                return;
            }

            Pracownik.FirstName = txtImie.Text;
            Pracownik.LastName = txtNazwisko.Text;
            Pracownik.Age = age;
            Pracownik.Position = cmbPosition.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
