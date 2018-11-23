using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krizic
{
    public partial class Form1 : Form
    {
        Graphics g;
        List<Pen> pens = new List<Pen>();
        bool potez = false;
        int p1;
        int p2;

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked && radioButton1.Enabled == true)
            {
                potez = true;
                radioButton1.Enabled = false;
            }
            else if (radioButton2.Checked && radioButton2.Enabled == true)
            {
                potez = false;
                radioButton2.Enabled = false;
            }
            if (!potez && radioButton2.Enabled == false)
            {
                textBox1.Text = "1. igrac je na potezu!";
                Circle C = new Circle();
                pens.Add(new Pen(Color.Orchid, 5F));
                C.draw(g, pens[0], e.X, e.Y);
                potez = true;
            }
            else if (potez && radioButton1.Enabled == false)
            {
                textBox1.Text = "2. igrac je na potezu!";
                Point p = new Point(e.X, e.Y);
                p1 = p.X;
                p2 = p.Y;
                pens.Add(new Pen(Color.Orchid, 5F));
                g.DrawRectangle(pens[0], p1 - 50, p2 - 50, 50, 50);
                potez = false;
            }
        }

        private void DrawLine(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Orange, 5F);
            Pen pen1 = new Pen(Color.Blue, 5F);
            Pen pen2 = new Pen(Color.Green, 5F);
            Pen pen3 = new Pen(Color.Pink, 5F);

            int x1 = 20;
            int y1 = 125;
            int x2 = 500;
            int y2 = 125;
            e.Graphics.DrawLine(pen, x1, y1, x2, y2);

            int x3 = 20;
            int y3 = 235;
            int x4 = 500;
            int y4 = 235;
            e.Graphics.DrawLine(pen1, x3, y3, x4, y4);

            int x5 = 125;
            int y5 = 10;
            int x6 = 125;
            int y6 = 350;
            e.Graphics.DrawLine(pen2, x5, y5, x6, y6);

            int x7 = 250;
            int y7 = 10;
            int x8 = 250;
            int y8 = 350;
            e.Graphics.DrawLine(pen3, x7, y7, x8, y8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    class Circle
    {
        private int r;

        public Circle()
        {
            r = 50;
        }
        public void draw(Graphics g, Pen p, int x, int y)
        {
            g.DrawEllipse(p, x, y, r, r);
        }
    }
}
