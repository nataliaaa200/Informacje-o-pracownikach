using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Informacje_o_pracownikach
{
    public partial class Form1 : Form
    {
        private int nextId = 1;
        private DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
        }
        private void InitializeGrid()
        {
            dataGridViewEmployees.ColumnCount = 5;
            dataGridViewEmployees.Columns[0].Name = "ID";
            dataGridViewEmployees.Columns[1].Name = "Imiê";
            dataGridViewEmployees.Columns[2].Name = "Nazwisko";
            dataGridViewEmployees.Columns[3].Name = "Wiek";
            dataGridViewEmployees.Columns[4].Name = "Stanowisko";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (dataTable == null) // SprawdŸ, czy tabela jest zainicjowana
            {
                InitializeDataTable(); // Inicjalizuj DataTable
            }
            var DodajPracownika = new DodajPracownika(nextId);
            if (DodajPracownika.ShowDialog() == DialogResult.OK)
            {
                var pracownik = DodajPracownika.Pracownik;
                dataTable.Rows.Add(pracownik.Id, pracownik.FirstName, pracownik.LastName, pracownik.Age, pracownik.Position);
                nextId++;
            }
        }
        private void InitializeDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Imiê");
            dataTable.Columns.Add("Nazwisko");
            dataTable.Columns.Add("Wiek");
            dataTable.Columns.Add("Stanowisko");

            dataGridViewEmployees.DataSource = dataTable;
        }
        private void btnUsuñ_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewEmployees.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridViewEmployees.Rows.Remove(row);
                    }
                }
            }
        }

        private void btnZapiszDoCsv_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.Title = "Wybierz lokalizacjê zapisu pliku CSV";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                     ExportujToCSV(dataGridViewEmployees, saveFileDialog.FileName);
                }
            }
        }

        private void btnCzytajZCsv_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
                openFileDialog.Title = "Wybierz plik CSV do wczytania";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LadujCSVToDataGridView(openFileDialog.FileName);
                }
            }
        }
        private void ExportujToCSV(DataGridView dataGridView, string filePath)
        {
            var csvContent = new StringBuilder();

            var headers = dataGridView.Columns
                .Cast<DataGridViewColumn>()
                .Select(column => column.HeaderText);

            csvContent.AppendLine(string.Join(",", headers));

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var fields = row.Cells
                        .Cast<DataGridViewCell>()
                        .Select(cell => cell.Value?.ToString() ?? "");

                    csvContent.AppendLine(string.Join(",", fields));
                }
            }

            File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
        }
        private void LadujCSVToDataGridView(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                dataTable = new DataTable();

                string[] headers = lines[0].Split(',');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(',');
                    dataTable.Rows.Add(values);
                }

                dataGridViewEmployees.DataSource = dataTable;
                if (dataTable.Rows.Count > 0)
                {
                    nextId = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0]) + 1;
                }
                else
                {
                    nextId = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"B³¹d dodawania pracownika: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

