using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public string Customer { get; set; }

        public string OrderDate { get; set; }

        public int Shipping_Address { get; set; }

        public int Order_Items { get; set; }

    }
}
