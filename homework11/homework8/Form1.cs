using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Data.Entity;

namespace homework8
{
    public partial class Form1 : Form
    {
        private string Query_Way;
        private string message;
        public Form1()
        {
            InitializeComponent();
            //messagetextBox.DataBindings.Add("Text", this, message);
        }

        private void 创建订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改订单 form2 = new 修改订单();
            form2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => Query_Way = querywaycomboBox.Text;
        // 按ID查询// 按客户查询//按数量查询//按商品查询//查询全部

        private void querybutton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.message);
            switch (Query_Way)
            {
                case "按ID查询":
                    using(var db=new OrderContext())
                    {
                        int Id1 = Convert.ToInt32(message);
                        var result = db.orders
                            .SingleOrDefault(o => o.OrderId == Id1);
                        orderbindingSource.DataSource = result;
                        detailbindingSource.DataSource = result.Details;
                    }
                    break;
                case "按客户查询":
                    using(var db=new OrderContext())
                    {
                        var result = db.orders.Where(o => o.Customer.Name == message).OrderBy(o => o.OrderId);
                        orderbindingSource.DataSource = result.ToList();
                        List<ordertest.OrderDetail> d_query=new List<ordertest.OrderDetail>();
                        foreach(var o in result)
                        {
                            foreach(var d in o.Details)
                            {
                                d_query.Add(d);
                            }
                        }
                        detailbindingSource.DataSource = d_query;
                    }
                    break;
                case "按数量查询":
                    using(var db =new OrderContext())
                    {
                        int a = Convert.ToInt32(message);
                        var result = db.details.Where(d => d.Amount ==a );
                        detailbindingSource.DataSource = result.ToList();
                        List<ordertest.Order> o_query = new List<ordertest.Order>();
                        foreach (var d in result)
                        {
                            o_query.Add(d.order);
                        }
                        orderbindingSource.DataSource = o_query;
                    }
                    break;
                case "按商品查询":
                    using(var db=new OrderContext())
                    {
                        var result = db.details.Where(d => d.Goods.Name == message);
                        detailbindingSource.DataSource = result.ToList();
                        List<ordertest.Order> o_query = new List<ordertest.Order>();
                        foreach (var d in result)
                        {
                            o_query.Add(d.order);
                        }
                        orderbindingSource.DataSource = o_query;
                    }
                    break;
                case "查询全部":
                    using(var db=new OrderContext())
                    {
                        var result = db.orders.ToList();
                        List<ordertest.OrderDetail> d_query = new List<ordertest.OrderDetail>();
                        foreach (var o in result)
                        {
                            foreach (var d in o.Details)
                            {
                                d_query.Add(d);
                            }
                        }
                        Console.WriteLine(d_query.Count());
                        orderbindingSource.DataSource = result;
                        detailbindingSource.DataSource = d_query;
                    }
                    break;
                default:break;
            }
        }

        private void 删除订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改订单 form2 = new 修改订单();
            form2.Show();
        }

        private void 修改订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改订单 form2 = new 修改订单();
            form2.Show();
        }

        private void messagetextBox_TextChanged(object sender, EventArgs e)
        {
            message = messagetextBox.Text;
        }

   
    }
}
