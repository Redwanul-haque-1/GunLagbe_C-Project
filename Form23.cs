using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project001
{
    public partial class Form23 : Form
    {
        bool sidebarExpand;
        int price;
        public Form23(int price)
        {
            InitializeComponent();
            textBox3.Text = price.ToString()+"$";
            this.price = price;
            textBox2.PasswordChar = '*'; // Initially set password char for hiding 

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form22 form = new Form22(price);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 form = new Form15();
            MessageBox.Show("Payment Done!");

            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            // set the minimum and maximum size of sizebar panel
            if (sidebarExpand)
            {
                //if sidebar expand, minimize
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //set timer intervalb to make it smoother
            SidebarTimer.Start();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form15 form = new Form15();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
