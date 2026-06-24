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
    public partial class Form4 : Form
    {
        string name, pass, mail, phn,license;
        public Form4(string name, string pass)
        {
            InitializeComponent();
            this.name=name; this.pass=pass; 

        }
        public void SearchByNameAndPassword(string name, string pass)
        {
            // Connection string to the local database
            string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Gun;Integrated Security=True";

            // SQL query to execute with parameters
            string query = "SELECT mail, phone, license FROM info WHERE name = @name AND npass = @password";

            // Using statement ensures that resources are disposed properly
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a SqlCommand to execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Adding parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@password", pass);

                        // Execute the command and obtain a SqlDataReader
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if any rows were returned
                            if (reader.HasRows)
                            {
                                // Read the data
                                while (reader.Read())
                                {
                                    // Read the specific columns
                                    mail = reader["mail"].ToString();
                                    phn = reader["phone"].ToString();
                                    license = reader["license"].ToString();

                                    // Print the values (optional)
                                    Console.WriteLine($"Mail: {mail}, Phone: {phn}, License: {license}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No records found for the provided name and password.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that may have occurred
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(name,pass);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6(name,pass);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7(name,pass);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchByNameAndPassword(name, pass);

            Form8 form = new Form8(name, pass, mail, phn,license);

            this.Hide();
            form.ShowDialog();
            this.Close();

        }

     /*  private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     */
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure to exit");
            this.Hide();
        }

       /* private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Transparent;
        }*/

        private void button8_Click(object sender, EventArgs e)
        {
            Form15 form = new Form15();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Transparent;
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }
    }
}
