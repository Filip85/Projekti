using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D.C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();
            t.Interval = 500;

            t.Tick += t_Tick;

            t.Start();

        }
       private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            label3.Text = DateTime.Now.ToString("dd MMM yyyy");
            label4.Text = DateTime.Now.ToString("dddd");

            string time = "";

            if(hh < 10)
            {
                time = "0" + hh;
            }
            else
            {
                time = Convert.ToString(hh);
            }
            time += ":";

            if(mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }


            circularProgressBar1.Text = time;

            circularProgressBar1.SubscriptText = "24H";

        }
    }
}
