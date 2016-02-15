using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaire2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message;

            


            message = String.Format("{0}\n{1}", textBox1.Text, textBox2.Text);
            MessageBox.Show(message);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex re = new Regex(@"^[a-z]{1,30}$");

            if (re.IsMatch(textBox1.Text))
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
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            label1.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex re = new Regex(@"^[0-9]+(,|.[0-9]+)?$");

            if (re.IsMatch(textBox2.Text))
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
