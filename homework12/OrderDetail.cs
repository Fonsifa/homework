using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace homework12 {
  [Serializable]
  public class OrderDetail {
    [Key]
    public int DetailId { set; get; }

    public Goods Goods { get; set; }

    public int Amount { get; set; }

        public int OrderID { set; get; }//foreign key
        [ForeignKey("OrderID")]
        public Order order { set; get; }

    public OrderDetail() { }
    public OrderDetail(Goods goods, int quantity,int ID) {
      this.Goods = goods;
      this.Amount = quantity;
      this.DetailId = ID;
    }

    public override bool Equals(object obj) {
      var detail = obj as OrderDetail;
      return detail != null &&
             EqualityComparer<Goods>.Default.Equals(Goods, detail.Goods);
    }

    public override int GetHashCode() {
      return 785010553 + EqualityComparer<Goods>.Default.GetHashCode(Goods);
    }

    public override string ToString() {
      return $"OrderDetail:{Goods},{Amount}";
    }
  }
}
