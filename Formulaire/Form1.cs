using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Formulaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MessageBox.Show(textBox1.Text + "\n" + textBox2.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex re_nom = new Regex(@"^[a-z]{2,5}$");
            

            if (re_nom.IsMatch(textBox1.Text))
            {
                textBox1.BackColor = Color.LightGreen;
                label1.Visible = false;
            }
            else
            {
                textBox1.BackColor = Color.Red;
                label1.Visible = true; 
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //if (textBox1.Text != "")
            //{
            //    textBox1.BackColor = Color.LightGreen;
            //}
            //else
            //{
            //    textBox1.BackColor = Color.Red;
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex re_date = new Regex(@"[0-3]?[0-9]/[0-1]?[0-9]/([0-9][0-9])?[0-9][0-9]");
            if (re_date.IsMatch(textBox2.Text))
            {
                textBox2.BackColor = Color.LightGreen;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
        }
    }
}
