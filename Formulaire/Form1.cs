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
            if (textBox1.BackColor == Color.LightGreen && textBox2.BackColor == Color.LightGreen && textBox3.BackColor == Color.LightGreen && textBox4.BackColor == Color.LightGreen)
            {
                MessageBox.Show(textBox1.Text + "\n" + textBox2.Text + "\n" + textBox3.Text + "\n" + textBox4.Text);
            }
            else
            {
                MessageBox.Show("Pas bon");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex re_nom = new Regex(@"^[a-zA-Z -]{1,30}$");
            

            if (re_nom.IsMatch(textBox1.Text))
            {
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                if (textBox1.Text == "")
                {
                    textBox1.BackColor = SystemColors.Window;
                }
                else
                {
                    textBox1.BackColor = Color.Red;
                }
                
            }
        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex re_date = new Regex(@"^[0-3]?[0-9]/[0-1]?[0-9]/([0-9][0-9])?[0-9][0-9]$");
            if (re_date.IsMatch(textBox2.Text))
            {
                textBox2.BackColor = Color.LightGreen;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Text = "";
            textBox4.Clear();

            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Regex re_date = new Regex(@"^[0-9]+(,[0-9]+)?$");
            if (re_date.IsMatch(textBox3.Text))
            {
                textBox3.BackColor = Color.LightGreen;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            Regex re_date = new Regex(@"^[0-9]{5}$");
            if (re_date.IsMatch(textBox4.Text))
            {
                textBox4.BackColor = Color.LightGreen;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Etes vous sûr ?", "Attention", MessageBoxButtons.YesNo);

            if (resultat == DialogResult.No)
            {
                e.Cancel = true;
            }
            

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
