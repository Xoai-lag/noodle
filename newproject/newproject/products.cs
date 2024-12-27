using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
    internal class products
    {
        public string product_id { get; set; }
        public string product_name { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public products(string id, string name, decimal gia, int sl)
        {
            product_id = id;
            product_name = name;
            price = gia;
            quantity = sl;
        }
        //Doc file
        public static List<products> ReadProductsFormFile(string filename)
        {
            var products = new List<products>();
            if (File.Exists(filename))
            {
                using (var reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        var parts = line.Split(',');
                        decimal price;
                        bool err = decimal.TryParse(parts[2], out price);
                        if (!err)
                        {
                            continue;
                        }
                        if (parts.Length == 4)
                        {
                            products product = new products(
                               parts[0], // product_id
                               parts[1], // product_name
                               price,
                               int.Parse(parts[3]) // quantity
                           );
                            products.Add(product);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("File products khong ton tai!");
            }
            return products;
        }

        //Ghi vao file
        public static bool WriteProductsToFile(string filename, List<products> ds)
        {
            if (!File.Exists(filename)) return false;
            using (var writer = new StreamWriter(filename))
            {
                foreach (var product in ds)
                {
                    writer.WriteLine($"{product.product_id},{product.product_name},{product.price},{product.quantity}");
                }
            }
            return true;
        }
    }
}
