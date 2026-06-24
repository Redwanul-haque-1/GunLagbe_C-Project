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
    public partial class Form5 : Form
    {
        string name, pass;
        public Form5(string name, string pass)
        {
            InitializeComponent();
            this.name = name;
            this.pass = pass;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Do you want to update information?", "Update info page", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Gun;Integrated Security=True";
                string query = "UPDATE info SET name = @newName, mail = @newEmail, phone = @newPhone WHERE npass = @password";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@newName", textBox1.Text);
                    command.Parameters.AddWithValue("@newEmail", textBox2.Text);
                    command.Parameters.AddWithValue("@newPhone", textBox3.Text);
                    command.Parameters.AddWithValue("@password", pass);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the command and check the number of affected rows
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Your information has been updated successfully.");
                            name = textBox1.Text;

                        }
                        else
                        {
                            Console.WriteLine("No account found with the provided password.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("An error occurred while updating the information: " + ex.Message);
                    }
                }
                MessageBox.Show("Your profile has been updated successfully");
                this.Hide();

                Form4 form = new Form4(name, pass);
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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
