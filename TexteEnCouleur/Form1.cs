using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexteEnCouleur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
            label1.Text = textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = checkBox1.Checked;
            if (checkBox1.Checked == false)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.BackColor = Color.Red;
            }
            else
            {
                label1.BackColor = SystemColors.Control;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label1.BackColor = Color.Green;
            }
            else
            {
                label1.BackColor = SystemColors.Control;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label1.BackColor = Color.Blue;
            }
            else
            {
                label1.BackColor = SystemColors.Control;
            }
        }
    }
}
