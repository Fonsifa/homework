using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {
  [Serializable]
  public class OrderDetail {

    public Goods Goods { get; set; }

    public uint Amount { get; set; }

    public double All {
      get => Goods.Price * Amount;
    }
    public OrderDetail() { }
    public OrderDetail(Goods goods, uint quantity) {
      this.Goods = goods;
      this.Amount = quantity;
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
