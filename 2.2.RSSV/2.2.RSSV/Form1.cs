using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace _2._2.RSSV
{
    public partial class Form1 : Form
    {
        string dat = "datoteka.txt";
        private System.Timers.Timer t;
        public Form1()
        {
            InitializeComponent();

            t = new System.Timers.Timer(1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(vrijeme);
        }

        private void vrijeme(object sender, ElapsedEventArgs e)
        {
            string line;
            StreamReader citac = new StreamReader(dat);

            while ((line = citac.ReadLine()) != null)
            {
                rtb_prikaz.Text += line + "\n";
                rtb_prikaz.Update();
                if (Convert.ToInt32(line) > Convert.ToInt32(tb_kriticna.Text))
                {
                    MessageBox.Show("Vrijednost je veća od kritične vrijednosti!");
                }
            }
            citac.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t.Enabled == false)
            {
                //Pokretanje timer-a.
                t.Start(); //Odgovara: t.Enabled = true;
                btn_pokreni.Text = "Zaustavi";
            }
            else
            {
                //Zaustavljanje timer-a
           
                btn_pokreni.Text = "Pokreni";
            }
        }
    }
}
