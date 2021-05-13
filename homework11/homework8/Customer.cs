using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {
    [Serializable]
    public class Customer {
    public int Id { get; set; }

    public string Name { get; set; }

    public Customer(int id, string name) {
      this.Id = id;
      this.Name = name;
    }
    public Customer() { }
    public override string ToString() {
      return $"customerId:{Id}, CustomerName:{Name}";
    }

    public override bool Equals(object obj) {
      var customer = obj as Customer;
      return customer != null &&
             Id == customer.Id;
    }

    public override int GetHashCode() {
      return 2108858624 + Id.GetHashCode();
    }
  }
}
