using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
    internal class item
    {
        public string OrderID {  get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public item(string order,string productId, int quantity, decimal price)
        {
            OrderID = order;
            ProductID = productId;
            Quantity = quantity;
            Price = price;
        }
    }
}
