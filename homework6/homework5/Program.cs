using System;
using System.Linq;
using System.Collections.Generic;

class Order
{
    private static uint ID_Allocte = 0;
    public uint ID { set; get; }
    public string OrderTime { set; get; }
    public string Customer { set; get; }
    public uint Money_Pay { set; get; }
    public Order()
    {
        Order.ID_Allocte++;
        this.ID = Order.ID_Allocte;
    }
    public Order(string OrderTime,string Customer,uint Money_Pay)
    {
        this.OrderTime = OrderTime;this.Customer = Customer;this.Money_Pay = Money_Pay;
        Order.ID_Allocte++;
        this.ID = Order.ID_Allocte;
    }
    public override bool Equals(object obj)
    {
        Order a = obj as Order;
        if (ID == a.ID && OrderTime== a.OrderTime && Money_Pay == a.Money_Pay && Customer == a.Customer)
            return true;
        else return false;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public override string ToString()
    {
        return ID + "-" + Customer + "-" + OrderTime + "-" + Money_Pay;
    }
}
class OrderDetails
{
    public string Goods { set; get; }
    public uint Price { set; get; }
    public uint Cont { set; get; }
    public OrderDetails() { }
    public OrderDetails(string Goods,uint price,uint Cont)
    {
        this.Goods = Goods;this.Price = price;this.Cont = Cont;
    }
    public override string ToString()
    {
        return Goods + "-数量:x" + (Cont) + "-单价:" + Price;
    }
    public override bool Equals(object obj)
    {
        OrderDetails a = obj as OrderDetails;
        if (Goods == a.Goods && Price == a.Price && Cont == a.Cont)
            return true;
        else return false;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
class OrderService
{
    public List<Tuple<Order, OrderDetails>> GoodsList = new List<Tuple<Order, OrderDetails>>();
    public void AddOrder()
    {
        Console.WriteLine("依次输入订单的时间，客户，金额");
        string Order_Time = Console.ReadLine();
        string Customer = Console.ReadLine();
        uint Money_Pay = Convert.ToUInt32(Console.ReadLine());
        Order a = new Order(Order_Time, Customer, Money_Pay);
        Console.WriteLine("订单已生成");
        Console.WriteLine("依次输入订单的商品，价格，数量");
        string Goods = Console.ReadLine();
        uint Price = Convert.ToUInt32(Console.ReadLine());
        uint Cont = Convert.ToUInt32(Console.ReadLine());
        OrderDetails b = new OrderDetails(Goods, Price, Cont);
        int k = GoodsList.Count;
        for(int i=0;i<k;i++)//订单和订单详情不可重复
        {
            if(GoodsList[i].Item1.Equals(a)||GoodsList[i].Item2.Equals(b))
            {
                throw new ArgumentOutOfRangeException("订单重复");
            }
        }
        this.GoodsList.Add(new Tuple<Order, OrderDetails>(a, b));
    }
    public void DeleteOrder(uint Id)//删除订单Id对应的订单
    {
        int cnt = GoodsList.Count;
        bool flag = false;
        for(int i=0;i<cnt;i++)
        {
            if(GoodsList[i].Item1.ID==Id)
            {
                GoodsList.Remove(GoodsList[i]);
                flag = true;
                break;
            }
        }
        if (!flag) throw new ArgumentException("没有这个订单");
    }
    public void OrderById(string _Id)
    {
        uint Id = Convert.ToUInt32(_Id);
        var Orders = from goods in GoodsList where goods.Item1.ID == Id select goods;
        foreach(var x in Orders)
        {
            Console.WriteLine(x.Item1.ToString(), x.Item2.ToString());
        }
    }
    public void OrderByGoods(string Goods)
    {
        var Orders = from goods in GoodsList where goods.Item2.Goods == Goods select goods;
        foreach (var x in Orders)
        {
            Console.WriteLine(x.Item1.ToString(), x.Item2.ToString());
        }
    }
    public void OrderByCustomer(string Customer)
    {
        var Orders = from goods in GoodsList where goods.Item1.Customer == Customer select goods;
        foreach (var x in Orders)
        {
            Console.WriteLine(x.Item1.ToString(), x.Item2.ToString());
        }
    }
    public void OrderByMoney(string _Money_Pay)
    {
        uint Money_Pay = Convert.ToUInt32(_Money_Pay);
        var Orders = from goods in GoodsList where goods.Item1.Money_Pay == Money_Pay select goods;
        foreach (var x in Orders)
        {
            Console.WriteLine(x.Item1.ToString(), x.Item2.ToString());
        }
    }
}

namespace homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService a = new OrderService();
            while(true)
            {
                int key;
                Console.WriteLine("1.添加订单 2.查询订单");
                key =Convert.ToInt32(Console.ReadLine());
                if (key == 1)
                {
                    a.AddOrder();
                }
                else if (key == 2)
                {
                    int key2 = 0;
                    Console.WriteLine("1.按Id查询 2.按商品查询 3.按客户查询 4.按支付金额查询");
                    key2 = Convert.ToInt32(Console.ReadLine());
                    switch (key2)
                    {
                        case 1:
                            {
                                Console.WriteLine("输入Id");
                                a.OrderById(Console.ReadLine());
                            }break;
                        case 2:
                            {
                                Console.WriteLine("输入商品名称");
                                a.OrderByGoods(Console.ReadLine());
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("输入客户");
                                a.OrderByCustomer(Console.ReadLine());
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("输入支付金额");
                                a.OrderByMoney(Console.ReadLine());
                            }
                            break;
                        default:throw new ArgumentException("没有这个选项");
                    }

                }
                else throw new ArgumentException("没有这个选项");
            }
        }
    }
}
