using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        private double length = 100;
        private uint n = 10;
        private Graphics g;
        private double th1 = 30 * Math.PI / 180;
        private double th2 = 20 * Math.PI / 180;
        private double per1 = 0.6;
        private double per2 = 0.7;
        private string color = "red";
        /* red
         blue
         yellow
         purple
         black
         green
         brown*/
        public Form1()
        {
            InitializeComponent();
        }
        public void drawline(double x0, double y0, double x1, double y1)
        {
            switch (color)
            {
                case "red": g.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "blue": g.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "yellow": g.DrawLine(Pens.Yellow, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "purple": g.DrawLine(Pens.Purple, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "black": g.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "green": g.DrawLine(Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "brown": g.DrawLine(Pens.Brown, (int)x0, (int)y0, (int)x1, (int)y1); break;
                default: throw new Exception("Wrong color");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.n = Convert.ToUInt32(textBox6.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.length = Convert.ToDouble(textBox4.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.per1 = Convert.ToDouble(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (g == null) g = this.panel1.CreateGraphics();
            else g.Clear(BackColor);
            var p_right = this.button1.Location;
            drawCaleyTree(n, p_right.X + this.button1.Size.Width / 2, p_right.Y - 50, length, -1 * Math.PI / 2);
            //drawCaleyTree(n, 200, 310, length, -1 * Math.PI / 2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.color = comboBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.per2 = Convert.ToDouble(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.th1 = Convert.ToDouble(textBox3.Text) * Math.PI / 180;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.th2 = Convert.ToDouble(textBox5.Text) * Math.PI / 180;
        }

        public void drawCaleyTree(uint step, double x0, double y0, double length, double th)
        {
            if (step == 0) return;
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);
            drawline(x0, y0, x1, y1);
            drawCaleyTree(step - 1, x1, y1, per1 * length, th + th1);
            drawCaleyTree(step - 1, x1, y1, per2 * length, th - th2);
        }
    }
}
