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

namespace GestionareMagazie
{
    public partial class InsertClienti : Form
    {
        public InsertClienti()
        {
            InitializeComponent();
        }

        private void buttonAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {

            string nume = textBoxNume.Text;
            string prenume = textBoxPrenume.Text;
            string email = textBoxEmail.Text;
            string connectionString = ConfigurationManager.ConnectionStrings["GestionareMagazieConnectionString"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Clienti (nume, prenume, email) VALUES (@nume, @prenume, @email)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nume", nume);
                        command.Parameters.AddWithValue("@prenume", prenume);
                        command.Parameters.AddWithValue("@email", email);
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
    }
}
