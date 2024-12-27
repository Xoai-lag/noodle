using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
    internal class Orders
    {
        public string OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public List<item> Items { get; set; }

        public Orders(string orderId, string customerName, DateTime orderDate, decimal totalPrice, List<item> items)
        {
            OrderID = orderId;
            CustomerName = customerName;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            Items = items;
        }

        //Doc file
        public static List<Orders> ReadOrdersFormFile(string filename)
        {
            var orders = new List<Orders>();
            if (File.Exists(filename))
            {
                using (var reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        var parts = line.Split('|'); // Giả sử dữ liệu đơn hàng được phân tách bởi '|'
                        if (parts.Length >= 4)
                        {
                            string orderId = parts[0];
                            string customerName = parts[1];
                            DateTime orderDate = DateTime.Parse(parts[2]);
                            decimal totalPrice = decimal.Parse(parts[3]);

                            var items = new List<item>();
                            // Phần còn lại là danh sách các món ăn
                            for (int i = 4; i < parts.Length; i++)
                            {
                                var itemParts = parts[i].Split(',');
                                string OrderID=itemParts[0];
                                string productId = itemParts[1];
                                int quantity = int.Parse(itemParts[2]);
                                decimal price = decimal.Parse(itemParts[3]);
                                items.Add(new item(OrderID,productId, quantity, price));
                            }
                            var order = new Orders(orderId, customerName, orderDate, totalPrice,items );
                            orders.Add(order);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("File orders không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return orders;
        }

        //Ghi file
        public static bool WriteOrdersToFile(string Filename,List<Orders> orders)
        {
            if (File.Exists(Filename)) {
                using (StreamWriter writer = new StreamWriter(Filename)) {
                    foreach (var order in orders)
                    {
                        // Ghi thông tin đơn hàng
                        var orderLine = $"{order.OrderID}|{order.CustomerName}|{order.OrderDate}|{order.TotalPrice}";
                        writer.WriteLine(orderLine);

                        // Ghi thông tin món ăn
                        foreach (var item in order.Items)
                        {
                            var itemLine = $"{item.ProductID},{item.Quantity},{item.Price}";
                            writer.WriteLine(itemLine);
                        }
                     }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
