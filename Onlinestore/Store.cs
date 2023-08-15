using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlinestore
{
    internal class Store
    {
        List<Product> products;

        public Store() { 
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void Displayproduct()
        {
            Console.WriteLine("Product in the list are");
            foreach(Product product in products)
            {
                Console.WriteLine($"Name : {product.Name}, Price : {product.Price}, Quantity : {product.Quantity}, Category : {product.Category}");
            }
        }
        public double Calculateamount() {
            double totalamount = 0;
            foreach(Product product in products)
            {
                totalamount += product.Price * product.Quantity;
            }
            return totalamount;
        }

    }
}
