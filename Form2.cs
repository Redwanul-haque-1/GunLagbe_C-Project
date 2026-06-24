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
    public partial class Form2 : Form
    {
        //private bool isPasswordVisible = false;

        public Form2()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*'; // Initially set password char for hiding 


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            Form4 form = new Form4(username,password);


            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            string connectionString = "Data Source =(LocalDb)\\MSSQLLocalDB;Initial Catalog=Gun;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);



            try
            {
                con.Open();

                // Parameterized query to prevent SQL injection
                string query = "SELECT COUNT(*) FROM info WHERE name = @username AND npass = @password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password); // Hashing passwords is recommended for security
                int count = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row

                if (count > 0)
                {
                    // User authenticated successfully
                    MessageBox.Show("Login successful!");

                    // Navigate to another form (optional)
                    // Form4 form = new Form4();
                    // form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            con.Close();
















            ////1. address of SQL server and database
            //string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Green;Integrated Security=True";

            ////2. establish connection
            //SqlConnection con = new SqlConnection(connectionString);

            ////3. open connection
            //con.Open();













            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(64, 222, 90);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             
            
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
           textBox1.BackColor = Color.DarkRed;
            textBox1.ForeColor = Color.Black;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.DarkRed;
            textBox1.ForeColor = Color.Black;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Toggle password visibility
            if (textBox2.PasswordChar == '*')
            {
                // Show the password by setting PasswordChar to empty
                textBox2.PasswordChar = '\0';
                button3.Text = "Hide Password"; // Optional: Change button text to indicate action
            }
            else
            {
                // Hide the password again
                textBox2.PasswordChar = '*';
                button3.Text = "Show Password"; // Optional: Change button text back
            }
        }
    }
}
