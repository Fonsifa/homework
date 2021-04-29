using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace homework9
{
    public partial class Form1 : Form
    {
        private string Start_url;
        private SimpleCrawler.SimpleCrawler Crawler = new SimpleCrawler.SimpleCrawler();
        public Form1()
        {
            InitializeComponent();
         //   URLbindingSource.DataSource = Crawler.u;
          //  dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Start_url = textBox1.Text;
        }

        private void stbutton_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Start_url, @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_]*)?$"))
            {
                Console.WriteLine("OK");
                Crawler.urls.Add(Start_url, false);//加入初始页面
                new Thread(Crawler.Crawl).Start();
            }
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            this.URLbindingSource.DataSource = Crawler.u;
            foreach(var i in Crawler.u)
            {
                Console.WriteLine(i.Url, "   ", i.OK);
            }
            Console.WriteLine("refresh"+Crawler.u.Count);
        }
    }
}
