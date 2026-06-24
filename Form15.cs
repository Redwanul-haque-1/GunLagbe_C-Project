using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project001
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form18 form = new Form18();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
        }

      /*  private void button7_Click(object sender, EventArgs e)
        {

        }*/

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Transparent;
        }

      /*  private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(64, 222, 90);
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.Transparent;
        } */

        private void button1_Click(object sender, EventArgs e)
        {
            Form16 form = new Form16();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form17 form = new Form17();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form19 form = new Form19();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    Form20 form = new Form20();
        //    this.Hide();
        //    form.ShowDialog();
        //    this.Close();
        //}

        private void button9_Click(object sender, EventArgs e)
        {
            Form21 form = new Form21();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form21 form = new Form21();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}