using LinqToDB.SchemaProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace GestionareMagazie
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AdjustDataGridViewColumns(DataGridView dataGridView)
        {
            int lastColumnIndex = dataGridView.Columns.Count - 1;

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                if (i != lastColumnIndex)
                {
                    dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                else
                {
                    dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void LoadData(string tabela)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GestionareMagazieConnectionString"].ConnectionString;
            string query = "SELECT * FROM " + tabela;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                AdjustDataGridViewColumns(dataGridView1);
                dataGridView1.DefaultCellStyle.BackColor = Color.LightBlue;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData("produse");
            AdjustDataGridViewColumns(dataGridView1);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonCutii_Click(object sender, EventArgs e)
        {
            LoadData("cutii");
            AdjustDataGridViewColumns(dataGridView1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

        }

        private void buttonClienti_Click(object sender, EventArgs e)
        {
            LoadData("clienti");
            AdjustDataGridViewColumns(dataGridView1);
        }

        private void buttonLivrari_Click(object sender, EventArgs e)
        {
            LoadData("livrari");
            AdjustDataGridViewColumns(dataGridView1);
        }

        private void buttonLocatii_Click(object sender, EventArgs e)
        {
            LoadData("locatii");
            AdjustDataGridViewColumns(dataGridView1);
        }

        private void buttonStoc_Click(object sender, EventArgs e)
        {
            LoadData("stoc");
            AdjustDataGridViewColumns(dataGridView1);
        }

        private void toolStripMenuItemExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "ExportedData.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDataToExcel(dataGridView1, saveFileDialog.FileName);
            }
        }

        private void ExportDataToExcel(DataGridView dataGridView, string fileName)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Sheet1");

            // Write the header
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                worksheet.Cell(1, i + 1).Value = dataGridView.Columns[i].HeaderText;
            }

            // Write the data
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cell(i + 2, j + 1).Value = dataGridView.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                }
            }

            workbook.SaveAs(fileName);
        }


        private void toolStripMenuItemExportCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.FileName = "ExportedData.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(saveFileDialog.FileName);
            }
        }
        private void ExportToCSV(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            string csvLine = string.Join(",", dataGridView1.Columns.Cast<DataGridViewColumn>().Select(col => col.HeaderText));
            sw.WriteLine(csvLine);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    csvLine = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value));
                    sw.WriteLine(csvLine);
                }
            }

            sw.Close();
        }

        private void produsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InsertProdus produsForm = new InsertProdus())
            {
                produsForm.ShowDialog();
            }
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InsertClienti clientiForm = new InsertClienti())
            {
                clientiForm.ShowDialog();
            }
        }

        private void toolStripMenuItemLightTheme_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void toolStripMenuItemBlueTheme_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }
    }
}
