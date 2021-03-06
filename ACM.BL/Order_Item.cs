using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order_Item
    {
        public Order_Item()
        {

        }

        public Order_Item(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal? PurchasePrice { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;

            if (ProductId <= 0) isValid = false;

            if (PurchasePrice <= 0 || PurchasePrice == null) isValid = false;

            return isValid;
        }

        public Order_Item Retrive(int Product)
        {
            return new Order_Item();
        }

        public List<Order_Item> Retrieve()
        {
            return new List<Order_Item>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
