using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework8
{
    public partial class 修改订单 : Form
    {
        public string id { set; get; }
        public string customer_name { set; get; }
        public string goods_name { set; get; }
        public string price { set; get; }
        public string amount { set; get; }
        public string customer_id { set; get; }
        public string goods_id { set; get; }
        public ordertest.OrderService service = new ordertest.OrderService();
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
            ordertest.Customer c = new ordertest.Customer(Convert.ToUInt32(customer_id), customer_name);
            ordertest.Goods goods = new ordertest.Goods(Convert.ToInt32(goods_id), goods_name, Convert.ToDouble(price));
            ordertest.OrderDetail de = new ordertest.OrderDetail(goods, Convert.ToUInt32(amount));
            if (op == 1)
            {
                if (service.GetById(id_int)==null)
                {
                    ordertest.Order o = new ordertest.Order(id_int, c);
                    service.AddOrder(o);o.AddDetails(de);
                }
                else
                {
                    service.GetById(id_int).AddDetails(de);
                }
            }
            else if(op==2)
            {
                ordertest.Order o = service.GetById(id_int);
                var d = o.Details;
                foreach (var i in d)
                {
                    if(i.Goods.Id== Convert.ToInt32(goods_id))
                    {
                        i.Amount = Convert.ToUInt32(amount);
                        i.Goods.Price = Convert.ToDouble(price);
                    }
                }
            }
            else if(op==3)
            {
                if (service.GetById(id_int) == null) throw new Exception("无此账单");
                else service.RemoveOrder(id_int);
                
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

    }
}
