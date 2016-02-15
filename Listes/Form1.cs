using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Insert(2, "Toto");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = listBox1.SelectedIndex.ToString();
            if (listBox1.SelectedIndex != -1)
            {
                label2.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                label2.Text = listBox1.SelectedItem.ToString();
            }
            else
            {
                label2.Text = "";
            }
        }
    }
}
