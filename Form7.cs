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

namespace project001
{
    public partial class Form7 : Form
    {
        string name, pass;

        public Form7(string name, string pass)
        {
            InitializeComponent();
            this.name = name;
            this.pass = pass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete your account?", "Account deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string connectionString = @"Data Source = (LocalDb)\\MSSQLLocalDB;Initial Catalog=gun;Integrated Security=True";
                string query = "DELETE FROM info WHERE npass = @pass AND name = @name"; // Optional: Use name to avoid deleting wrong accounts

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set the parameters
                        command.Parameters.AddWithValue("@pass", pass);
                        command.Parameters.AddWithValue("@name", name); // Optional

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if a row was deleted
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Your account has been deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No account found with the given password.");
                        }
                    }
                }
                Form1 form = new Form1();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                Form4 form = new Form4(name, pass);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }




        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;        
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
