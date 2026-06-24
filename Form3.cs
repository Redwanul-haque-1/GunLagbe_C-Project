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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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
            Form2 form = new Form2();




            string n = textBox1.Text;
            string mail = textBox2.Text;
            string phn = textBox3.Text;
            string npass = textBox4.Text;
            string cpass = textBox5.Text;
            string license = textBox6.Text;

            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" ||
                textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" ||
                textBox5.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all the text boxes.");
            }
            else if (npass != cpass)
            {
                MessageBox.Show("Please fill both password field correctly!");
            }
            else
            {
                //1. address of SQL server and database
                string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Gun;Integrated Security=True";

                //2. establish connection
                SqlConnection con = new SqlConnection(connectionString);

                //3. open connection
                con.Open();
                //4. prepare qurery
                string qry = "insert into info (name,mail,phone,npass,cpass,license) values('" + n + "','" + mail + "','" + phn + "','" + npass + "','" + cpass + "','"+license+"');\r\n";

                //5. execute qurrey
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();

                //6. Close connection
                con.Close();

                MessageBox.Show("Registration Successful");
                System.Console.WriteLine(n);

                this.Hide();
                form.ShowDialog();
                this.Close();

            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(64, 222, 90);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
