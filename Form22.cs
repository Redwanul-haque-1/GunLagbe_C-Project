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
    public partial class Form22 : Form
    {
        bool sidebarExpand;
        int price;
        public Form22(int price)
        {
            InitializeComponent();
            textBox1.Text = price.ToString()+"$";
            this.price = price;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form23 form = new Form23(price);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form15 form = new Form15();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form23 form = new Form23(price);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form23 form = new Form23(price);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            // set the minimum and maximum size of sizebar panel
            if(sidebarExpand)
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
                if(Sidebar.Width == Sidebar.MaximumSize.Width)
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

        private void button5_Click(object sender, EventArgs e)
        {

            Form15 form = new Form15();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
