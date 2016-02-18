using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationsListbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && listBox1.Items.Contains(textBox1.Text)==false) 
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();
                textBox2.Text = listBox1.Items.Count.ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = (listBox1.SelectedIndex+1).ToString();
            if (listBox1.SelectedItem != null)
            {
                textBox4.Text = listBox1.SelectedItem.ToString();
            }
            else
            {
                textBox4.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox5.Text) <= listBox1.Items.Count)
            {
                listBox1.SelectedIndex = Convert.ToInt32(textBox5.Text) - 1;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Focus();
        }
    }
}
