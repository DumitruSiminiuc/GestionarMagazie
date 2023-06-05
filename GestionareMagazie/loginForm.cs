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
using LinqToDB;

namespace GestionareMagazie
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;

        }
        private bool VerifyCredentials(string username, string password)
        {
            bool isValid = false;

            // conectare la baza de date.

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["GestionareMagazieConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Utilizatori WHERE email = @Email AND parola = @Parola", connection))
                    {
                        command.Parameters.AddWithValue("@Email", username);
                        command.Parameters.AddWithValue("@Parola", password);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isValid = reader.HasRows;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
            }

            return isValid;
        }

    }
}
