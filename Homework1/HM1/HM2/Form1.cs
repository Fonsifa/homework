using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM2
{
    public partial class Form1 : Form
    {
        string s1, s2,op;
        double n1, n2, ans;
        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            op = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+": ans = n1 + n2; break;
                case "-": ans = n1 - n2; break;
                case "*": ans = n1 * n2; break;
                case "/": ans = n1 / n2; break;
                case "%": ans = n1 % n2; break;
                default: ans = -10000; break;
            }
            textBox3.Text = Convert.ToString(ans);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            n1 =Convert.ToDouble(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(textBox2.Text);
        }

    }
}
