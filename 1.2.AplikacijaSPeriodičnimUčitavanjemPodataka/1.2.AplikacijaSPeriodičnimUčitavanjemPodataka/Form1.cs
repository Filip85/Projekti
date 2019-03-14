using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace _1._2.AplikacijaSPeriodičnimUčitavanjemPodataka
{
    public partial class Form1 : Form
    {
        string ulaznadat = "matrica.txt";
        int brredaka, brstupaca;
        string kriticna;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Pokreni_Click(object sender, EventArgs e)
        {
            ulaznadat = tbx_UlaznaDat.Text;
            kriticna = tb_KriticnaVrijednost.Text;
            string line, r, s;
            StreamReader citac = new StreamReader(ulaznadat);
            r = citac.ReadLine(); s = citac.ReadLine();
            int.TryParse(r, out brredaka);
            int.TryParse(s, out brstupaca);
            while ((line = citac.ReadLine()) != null) //Čitanje redak po redak
            { //Svaki redak rastavljamo na broj stupaca
                string[] parts = line.Split(new Char[] { '\t', ' ', ',' });
                for(int j = 0; j < brstupaca; j++)
                {

                    richTextBox.Text += parts[j] + "\n";

                    if(Convert.ToInt32(parts[j]) > Convert.ToInt32(kriticna))
                    {
                        MessageBox.Show("Vrijendost elementa prelazi kritičnu vrijendost");
                    }

                    Thread.Sleep(1000);
                }
            }
            citac.Close();//Zatvaranje stream-a za čitanje 
        }
    }
}
