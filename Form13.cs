using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace project001
{
    public partial class Form13 : Form
    {

        public Form13()
        {
            InitializeComponent();

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4("","");
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void HideAllControls()
        {
            checkedListBox1.Visible = false;
            listBox1.Visible = false;
            button8.Visible = false;

            checkedListBox2.Visible = false;
            checkedListBox3.Visible = false;
            checkedListBox4.Visible = false;
            checkedListBox5.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideAllControls();

            checkedListBox1.Visible = true;
            listBox1.Visible = true;
            button8.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideAllControls();
            
            checkedListBox2.Visible = true;
            listBox1.Visible = true;
            button8.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideAllControls();

            checkedListBox3.Visible = true;
            listBox1.Visible = true;
            button8.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HideAllControls();

            checkedListBox4.Visible = true;
            listBox1.Visible = true;
            button8.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HideAllControls();

            checkedListBox5.Visible = true;
            listBox1.Visible = true;
            button8.Visible = true;
        }


      

       

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
            foreach (var item in checkedListBox2.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
            foreach (var item in checkedListBox3.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
            foreach (var item in checkedListBox4.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
            foreach (var item in checkedListBox5.CheckedItems)
            {
                listBox1.Items.Add(item);
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
