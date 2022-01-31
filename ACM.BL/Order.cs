using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {

        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; set; }

        public string Customer { get; set; }

        public DateTimeOffset? OrderDate { get; set; }

        public int Shipping_Address { get; set; }

        public int Order_Items { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public Order Retrive(int Customer_Id)
        {
            return new Order();
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool save()
        {
            return true;
        }
    }
}
