using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework12 {
    [Serializable]
    public class Order :IComparable<Order>{
    [Key]
    public string OrderId { get; set; }

    public Customer Customer { get; set; }

    public DateTime CreateTime{ get; set; }


    public List<OrderDetail> Details { get; set; } = new List<OrderDetail>();


    public Order(string orderId, Customer customer) {
      OrderId = orderId;
      Customer = customer;
      CreateTime = DateTime.Now;
    }
    public Order(){ }
    public void AddDetails(OrderDetail orderDetail) {
      if (this.Details.Contains(orderDetail)) {
        throw new ApplicationException($"The goods ({orderDetail.Goods.Name}) exist in order {OrderId}");
      }
      Details.Add(orderDetail);
    }

    public int CompareTo(Order other) {
     if(other==null) return 1;
     int id1=Convert.ToInt32(OrderId);
     int id2=Convert.ToInt32(other.OrderId);
     return id1-id2;
    }

    public override bool Equals(object obj) {
      var order = obj as Order;
      return order != null && OrderId == order.OrderId;
    }

    public override int GetHashCode() {
      return 2108858624 + OrderId.GetHashCode();
    }

    public void RemoveDetails(int num) {
      Details.RemoveAt(num);
    }

    public override string ToString() {
      String result = $"orderId:{OrderId}, customer:({Customer})";
      Details.ForEach(detail => result += "\n\t" + detail);
      return result;
    }


  }
}
