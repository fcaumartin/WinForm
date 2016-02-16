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
            Button b = (Button)sender;

            textBox1.Text += b.Text + "+";
            somme += Convert.ToInt32(b.Text);
           
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
