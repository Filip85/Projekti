using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace _2._3.RSSV_alarm
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer t;
        public Form1()
        {
            InitializeComponent();
            t = new System.Timers.Timer(1000);
            //Dodavanje događaja timer-u; izvršava se periodno
            t.Elapsed += new System.Timers.ElapsedEventHandler(vrijeme);
        }

        private void vrijeme(object sender, ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;

            if(currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                t.Stop();
                Console.Beep();
                label1.Text = "Nema više vremena!";
                tb_start_stop.Text = "Pokreni";
                MessageBox.Show("Buđenje!!!");
            }
            else
            {
                label1.Text = "Ima još vremena!";
            }
        }

        private void tb_start_stop_Click(object sender, EventArgs e)
        {
            if(t.Enabled == false)
            {
                t.Start();
                tb_start_stop.Text = "Zaustavi";

            }
            else
            {
                t.Stop();
                tb_start_stop.Text = "Pokreni";
            }
        }
    }
}
