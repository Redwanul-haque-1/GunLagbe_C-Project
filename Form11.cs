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
    public partial class Form11 : Form
    {
        string name, pass;

        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

           // button1.BackColor = Color.FromArgb(64,222,90);

            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            name = username;
            pass = password;
            Form4 form = new Form4(name, pass);


            // Check if username or password is empty
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
                string query = "SELECT COUNT(*) FROM admininfo WHERE name = @username AND npass = @password";
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
            finally
            {
                con.Close();
            }












            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
