using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.RSSV
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer t;
        public Form1()
        {
            InitializeComponent();

            t = new System.Timers.Timer(1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(vrijeme);
        }

        private void vrijeme(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                lbl_vrijeme.Text = DateTime.Now.ToLongTimeString();
            });
        }

        private void btn_start_stop_Click(object sender, EventArgs e)
        {
            if(t.Enabled == false)
            {
                t.Start();
                btn_start_stop.Text = "Zaustavi";
            }
            else
            {
                t.Stop();
                btn_start_stop.Text = "Pokreni";
            }
        }
    }
}
