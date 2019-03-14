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

namespace _1.RSSV
{
    public partial class Form1 : Form
    {
        int[,] Matrica;
        int[,] TransponiranaMatrica;
        int brredaka, brstupaca;
        int min, max;
        string ulaznadat = "matrica.txt";
        string izlaznadat = "matrica.txt";
        int skalar;
        bool generirana = false;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_UcitajDat_Click(object sender, EventArgs e)
        {
            ulaznadat = tbx_UlaznaDat.Text;
            string line, r, s;
            int cnt = 0; //Brojač redaka
            StreamReader citac = new StreamReader(ulaznadat);
            r = citac.ReadLine(); s = citac.ReadLine();
            int.TryParse(r, out brredaka);
            int.TryParse(s, out brstupaca);
            Matrica = new int[brredaka, brstupaca];
            while ((line = citac.ReadLine()) != null) //Čitanje redak po redak
            { //Svaki redak rastavljamo na broj stupaca
                string[] parts = line.Split(new Char[] { '\t', ' ', ',' });
                for (int j = 0; j < brstupaca; j++)
                {
                    int.TryParse(parts[j], out Matrica[cnt, j]);
                    //Dohvaćamo podatke za donju i gornju granicu
                    if (cnt == 0)
                        min = max = Matrica[0, 0];
                    if (Matrica[cnt, j] < min)
                        min = Matrica[cnt, j];
                    if (Matrica[cnt, j] > max)
                        max = Matrica[cnt, j];
                }
                cnt++;
            }
            citac.Close();//Zatvaranje stream-a za čitanje
            generirana = true;
            //Ispis matrice u text polje
            rtbx_Matrica.Text = "";
            for (int i = 0; i < brredaka; i++)
            {
                for (int j = 0; j < brstupaca; j++)
                {
                    // Zapis u rich text box
                    rtbx_Matrica.Text += Matrica[i, j].ToString() + "\t";
                }
                // Umetanje razmaka između redove, radi ljepšeg izgleda
                rtbx_Matrica.Text += "\n\n";
            }

            //Ažuriranje podataka
            tbx_BrRedaka.Text = brredaka.ToString();
            tbx_BrStupaca.Text = brstupaca.ToString();
            tbx_DonjaGr.Text = min.ToString();
            tbx_GornjaGr.Text = max.ToString();

        }

        private void btn_MnoziSkalarom_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbx_Skalar.Text, out skalar) && generirana == true)
            {
                // Očistimo tekst za ispis
                rtbx_Matrica.Text = "";
                // U petlji množimo i zapisujemo u text polje
                for (int i = 0; i < brredaka; i++)
                {
                    for (int j = 0; j < brstupaca; j++)
                    {
                        Matrica[i, j] *= skalar;
                        rtbx_Matrica.Text += Matrica[i, j].ToString() + "\t";
                    }
                    rtbx_Matrica.Text += "\n\n";
                }
            }
            // Ako je došlo do pogreške obavijestimo korisnika
            else
            {
                MessageBox.Show("Molim provjerite skalar i matricu, nešto nedostaje", "Neuspješno množenje");
            }
        }

        private void btn_ZapisDat_Click(object sender, EventArgs e)
        {
            izlaznadat = tbx_IzlaznaDat.Text;
            //Može se zapisati samo ako je matrica generirana
            if (generirana)
            {
                StreamWriter pisac = new StreamWriter(izlaznadat);
                pisac.WriteLine(brredaka); //Zapisujemo podatak o broju redaka
                pisac.WriteLine(brstupaca); //te o broju stupaca
                for (int i = 0; i < brredaka; i++)
                {
                    for (int j = 0; j < brstupaca; j++)
                        pisac.Write(Matrica[i, j].ToString() + "\t");
                        pisac.WriteLine(); //Prelazak u novi redak
                }
                pisac.Close(); //Zatvaranje stream-a za pisanje
            }

        }

        private void btn_Transponiraj_Click(object sender, EventArgs e)
        {
            int i, j;

            TransponiranaMatrica = new int[brredaka, brstupaca];
            rtbx_Matrica.Text = "";

            for (i = 0; i < brstupaca; i++)
            {
                for(j = 0; j < brredaka; j++)
                {
                    TransponiranaMatrica[i, j] = Matrica[i, j];
                 

                }
            }

            for (i = 0; i < brredaka; i++)
            {
                for (j = 0; j < brstupaca; j++)
                {
                    // Zapis u rich text box
                    rtbx_Matrica.Text += TransponiranaMatrica[j, i].ToString() + "\t";
                }
                // Umetanje razmaka između redove, radi ljepšeg izgleda
                rtbx_Matrica.Text += "\n\n";
            }


        }

        private void btn_Generiraj_Click(object sender, EventArgs e)
        {
            // Čitanje podataka iz text boxova u varijable
            if (int.TryParse(tbx_BrRedaka.Text, out brredaka) &&
            int.TryParse(tbx_BrStupaca.Text, out brstupaca) &&
            int.TryParse(tbx_DonjaGr.Text, out min) &&
            int.TryParse(tbx_GornjaGr.Text, out max))
            {
                // Kreiranje 2D polja odgovarajućih dimenzija
                Matrica = new int[brredaka, brstupaca];
                // Osiguramo da je text polje prazno
                rtbx_Matrica.Text = "";
                for (int i = 0; i < brredaka; i++)
                {
                    for (int j = 0; j < brstupaca; j++)
                    {
                        // Popunjavanje random vrijednostima unutar granica
                        Matrica[i, j] = rand.Next(min, max);
                        // Zapis u rich text box
                        rtbx_Matrica.Text += Matrica[i, j].ToString() + "\t";
                    }
                    // Umetanje razmaka između redove, radi ljepšeg izgleda
                    rtbx_Matrica.Text += "\n\n";
                }
                generirana = true;
            }
            // Ako su polja prazna ili sadrže nešto osim brojeva
            else
            {
                MessageBox.Show("Molim provjerite parametre. Pogrešan unos u jednom od polja","Neuspješno generiranje"); 
            }
        }

        private void btn_Izlaz_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }
    }
}
