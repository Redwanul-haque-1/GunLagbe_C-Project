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
    public partial class Form8 : Form
    {
        string name, pass, mail, phn,license;
        public Form8(string name, string pass, string mail, string phn, string license)
        {
            InitializeComponent();
            this.name = name;
            this.pass = pass;
            this.mail = mail;
            this.phn = phn;
            this.license = license;
            textBox1.Text = name;
            textBox2.Text = mail;
            textBox3.Text = phn;
            textBox4.Text = license;



            MessageBox.Show(
                    $"Name: {name}\nEmail: {mail}\nPhone: {phn}");

        }




        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(name, pass);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text =this. name;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form8_MouseHover(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           

        }
        //private void SearchByNameAndPassword()
        //{
        //    string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Gun;Integrated Security=True";
        //    SqlConnection con = new SqlConnection(connectionString);

        //    try
        //    {
        //        con.Open();

        //        // Parameterized query to prevent SQL injection
        //        string query = "SELECT * FROM info WHERE name = @name AND npass = @password";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.Parameters.AddWithValue("@name", name);
        //        cmd.Parameters.AddWithValue("@password", pass); // Hashing passwords is recommended for security

        //        SqlDataReader reader = cmd.ExecuteReader();

        //        if (reader.HasRows)
        //        {
        //            reader.Read(); // Assuming only one matching row

        //            // Retrieve additional information
        //            mail = reader["mail"].ToString();
        //            phn = reader["phone"].ToString();
        //            textBox2.Text = this.name;
        //            textBox1.Text = this.pass;
        //            textBox3.Text = phn;
        //            MessageBox.Show(
        //               $"Name: {name}\nEmail: {mail}\nPhone: {phn}");



        //            // ... (retrieve other columns as needed)

        //            // Display retrieved information (example using a MessageBox)
        //            //MessageBox.Show(
        //            //    $"Name: {name}\nEmail: {mail}\nPhone: {phone}");

        //            // You can also populate other UI elements with the retrieved data
        //        }
        //        else
        //        {
        //            MessageBox.Show("No matching user found.");
        //        }

        //        reader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();

        //    }
        //}
    } 
}
