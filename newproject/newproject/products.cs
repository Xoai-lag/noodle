using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
    internal class products
    {
        public string product_id {  get; set; }
        public string product_name { get; set; }
        public decimal price { get; set; }
        public int quantity {  get; set; }
        public products(string id,string name, decimal gia,int sl)
        {
            product_id= id;
            product_name= name;
            price = gia;
            quantity = sl;
        }
        //Doc file
        public static List<products> ReadProductsFormFile(string filename)
        {
            var products = new List<products>();
            if (File.Exists(filename)) {
                try
                {
                    using (var reader = new StreamReader(filename))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (string.IsNullOrWhiteSpace(line)) continue;
                            var parts = line.Split(',');
                            if (parts.Length == 4)
                            {
                                var product = new products(
                                   parts[0], // product_id
                                   parts[1], // product_name
                                   decimal.Parse(parts[2]), // price
                                   int.Parse(parts[3]) // quantity
                               );
                                products.Add(product);
                            }
                        }
                        return products;
                    }
                }catch (Exception) {
                    
                }
            }
        }
    }
}
