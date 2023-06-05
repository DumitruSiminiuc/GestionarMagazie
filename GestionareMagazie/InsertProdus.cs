using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace GestionareMagazie
{
    public partial class InsertProdus : Form
    {
        public InsertProdus()
        {
            InitializeComponent();
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            string denumire = textBoxDenumire.Text;
            string descriere = textBoxDescriere.Text;
            string unitateMasura = textBoxUnitateDeMasura.Text;
            decimal pret = decimal.Parse(textBoxPret.Text);
            DateTime dataExpirarii = dateTimePickerExpirare.Value;
            string connectionString = ConfigurationManager.ConnectionStrings["GestionareMagazieConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("INSERT INTO Produse (denumire, descriere, unitate_de_masura, pret, data_expirarii) VALUES (@denumire, @descriere, @unitateMasura, @pret, @dataExpirarii)", connection))
                    {
                        command.Parameters.AddWithValue("@denumire", denumire);
                        command.Parameters.AddWithValue("@descriere", descriere);
                        command.Parameters.AddWithValue("@unitateMasura", unitateMasura);
                        command.Parameters.AddWithValue("@pret", pret);
                        command.Parameters.AddWithValue("@dataExpirarii", dataExpirarii);

                        command.ExecuteNonQuery();
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding client: " + ex.Message);
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }      
}
