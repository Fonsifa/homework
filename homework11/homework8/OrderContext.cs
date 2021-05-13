using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Entity;

namespace homework8
{
    class OrderContext:DbContext
    {
        public OrderContext():base("OrderDataBase")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrderContext>());
        }
        public DbSet<ordertest.Order> orders { set; get; }
        public DbSet<ordertest.OrderDetail> details { set; get; }
    }
}
