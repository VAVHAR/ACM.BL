using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrive(int OrderId)
        {
            Order order = new Order(OrderId);

            if (OrderId == 1)
            {
                order.Customer = "Hardik";
                order.Order_Items = 2;
            }

            return order;
        }
        public bool Save()
        {
            return true;
        }
    }
}
