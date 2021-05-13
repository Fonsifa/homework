using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {
    [Serializable]
    public class Order :IComparable<Order>{
    [Key]
    public int OrderId { get; set; }

    public Customer Customer { get; set; }

    public DateTime CreateTime{ get; set; }


    public List<OrderDetail> Details { get; set; } = new List<OrderDetail>();


    public Order(int orderId, Customer customer) {
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
     return OrderId - other.OrderId;
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
