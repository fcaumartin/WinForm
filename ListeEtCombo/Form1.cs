using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeEtCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string s in comboBox1.Items) {
                listBox1.Items.Add(s);
            }
            comboBox1.Items.Clear();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            comboBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (string s in listBox1.Items)
            {
                comboBox1.Items.Add(s);
            }
            listBox1.Items.Clear();
            button3.Enabled = false;
            button4.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                button1.Enabled = false; 
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                listBox1.Items.Add(comboBox1.SelectedItem.ToString());
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                button1.Enabled = false;
                if (comboBox1.Items.Count==0)
                {
                    button2.Enabled = false;
                }
                comboBox1.Text = "";
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && !comboBox1.Items.Contains(comboBox1.Text) && !listBox1.Items.Contains(comboBox1.Text))
            {
                comboBox1.Items.Add(comboBox1.Text);
                comboBox1.Text = "";
            }
            if (comboBox1.Items.Count > 0)
            {
                button2.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count-1)
            {
                int i = listBox1.SelectedIndex;

                string tmp = listBox1.Items[i + 1].ToString();
                listBox1.Items[i + 1] = listBox1.Items[i];
                listBox1.Items[i] = tmp;
                listBox1.SelectedIndex = i + 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                int i = listBox1.SelectedIndex;

                string tmp = listBox1.Items[i - 1].ToString();
                listBox1.Items[i - 1] = listBox1.Items[i];
                listBox1.Items[i] = tmp;
                listBox1.SelectedIndex = i - 1;
            }
        }
    }
}
