using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;

namespace homework8
{
    public partial class 修改订单 : Form
    {
        public string id { set; get; }
        public string customer_name { set; get; }
        public string detail_id { set; get; }
        public string goods_name { set; get; }
        public string price { set; get; }
        public string amount { set; get; }
        public string customer_id { set; get; }
        public string goods_id { set; get; }
        public int op { set; get; }
        public 修改订单()
        {
            InitializeComponent();
          /*  IDtextBox.DataBindings.Add("Text", this, id);
            customertextBox.DataBindings.Add("Text", this, customer_name);
            customeridtextBox.DataBindings.Add("Text", this, customer_id);
            goodstextBox.DataBindings.Add("Text", this, goods_name);
            pricetextBox.DataBindings.Add("Text", this, price);
            amounttextBox.DataBindings.Add("Text", this, amount);
            goodsidtextBox.DataBindings.Add("Text", this, goods_id);
            label2.DataBindings.Add("Text", this, customer_name);*/
        }


        private void 修改订单_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(this.id, this.customer_name, this.customer_id);
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            op = 1;
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            op = 2;
        }
        private void deletebutton_Click(object sender, EventArgs e)
        {
            op = 3;
        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(this.id, this.customer_name, this.customer_id);
            int id_int = Convert.ToInt32(id);
            ordertest.Customer c = new ordertest.Customer(Convert.ToInt32(customer_id), customer_name);
            ordertest.Goods goods = new ordertest.Goods(Convert.ToInt32(goods_id), goods_name, Convert.ToDouble(price));
            ordertest.OrderDetail de = new ordertest.OrderDetail(goods, Convert.ToInt32(amount), Convert.ToInt32(detail_id));
            if(op==1)
            {
                using(var db=new OrderContext())
                {
                    var r = db.orders.Where(o => o.OrderId == id_int);
                    if(r.Count()!=0)
                    {
                        ordertest.OrderDetail ds = new ordertest.OrderDetail()
                        {
                            Goods = goods,
                            Amount = Convert.ToInt32(amount),
                            DetailId = Convert.ToInt32(detail_id),
                        };
                        db.Entry(ds).State = EntityState.Added;
                        db.SaveChanges();
                    }
                    else
                    {
                        ordertest.Order o = new ordertest.Order(id_int, c);
                        ordertest.OrderDetail ds = new ordertest.OrderDetail()
                        {
                            Goods = goods,
                            Amount = Convert.ToInt32(amount),
                            DetailId = Convert.ToInt32(detail_id),
                        };
                        o.Details = new List<ordertest.OrderDetail>();
                        o.Details.Add(ds);
                        db.orders.Add(o);
                        db.SaveChanges();
                    }
                }
            }
            else if(op==2)
            {
                using(var db=new OrderContext())
                {
                    var d = new ordertest.OrderDetail() { DetailId = de.DetailId,OrderID=de.OrderID};
                    db.Entry(d).State = EntityState.Modified;
                    d = de;
                    db.SaveChanges();
                }
            }
            else if(op==3)
            {
                using (var db = new OrderContext())
                {
                    var r = db.orders.FirstOrDefault(o => o.OrderId == id_int);
                    var r_de = db.details.FirstOrDefault(d => d.DetailId == de.DetailId);
                    if(r!=null&&r_de!=null)
                    {
                        db.details.Remove(r_de);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("无此订单");
                    }
                }
            }
            MessageBox.Show("信息改变已保存");
            this.Close();
        }
        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {
            id = IDtextBox.Text;
        }

        private void customertextBox_TextChanged(object sender, EventArgs e)
        {
            customer_name = customertextBox.Text;
        }

        private void customeridtextBox_TextChanged(object sender, EventArgs e)
        {
            customer_id = customeridtextBox.Text;
        }

        private void goodstextBox_TextChanged(object sender, EventArgs e)
        {
            goods_name = goodstextBox.Text;
        }

        private void goodsidtextBox_TextChanged(object sender, EventArgs e)
        {
            goods_id = goodsidtextBox.Text;
        }

        private void amounttextBox_TextChanged(object sender, EventArgs e)
        {
            amount = amounttextBox.Text;
        }

        private void pricetextBox_TextChanged(object sender, EventArgs e)
        {
            price = pricetextBox.Text;
        }

        private void detailidtextBox_TextChanged(object sender, EventArgs e)
        {
            detail_id = detailidtextBox.Text;
        }
    }
}
