using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Additionneur
{
    public partial class Form1 : Form
    {
        int somme = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1+";
            somme += 1;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2+";
            somme += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " = " + somme + "+";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
