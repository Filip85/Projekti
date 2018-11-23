using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> popis = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                popis.Add(textBox1.Text);
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                button2.Enabled = true;
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Niste unijeli ime!", "Upozorenje");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Greška");
                button2.Enabled = false;
            }
            else
            {
                popis.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Clear();

                foreach (string i in popis)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            popis.Sort();
            listBox1.Items.Clear();

            foreach (string i in popis)
            {
                listBox1.Items.Add(i);
            }

            if (listBox1.Items.Count == 0)
            {
                button2.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
