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
    public partial class Form6 : Form
    {
        string name, pass;
        public Form6(string name, string pass)
        {
            InitializeComponent();
            this.name = name;
               this.pass = pass;    
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(64, 222, 90);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Code to update password

            // 1. Get new password from user interface (e.g., textbox)
            string newPassword = textBox2.Text ;

            // 2. Connection string to the local database
            string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Gun;Integrated Security=True";

            // 3. SQL query to update password
            string query = "UPDATE info SET npass = @newPassword WHERE name = @name AND npass = @oldPassword";

            // 4. Using statement ensures that resources are disposed properly
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a SqlCommand   
                    //to execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@name",
 name);
                        command.Parameters.AddWithValue("@oldPassword",
 pass); // Update using current password
                        command.Parameters.AddWithValue("@newPassword", newPassword);

                        // Execute the command and check for affected rows
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!");
                            this.pass = newPassword; // Update local variable with new password
                        }
                        else
                        {
                            MessageBox.Show("Error updating password. Please check your current password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that may have occurred
                    Console.WriteLine("Error: " + ex.Message);
                    MessageBox.Show("An error occurred. Please try again later.");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(name,pass);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
