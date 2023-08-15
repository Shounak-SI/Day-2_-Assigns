using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Onlineshopping
{
    internal class Shoppingcart
    {
        private List<Item> items;

        public Shoppingcart()
        {
            items = new List<Item>();
        }

        public void  Additem(Item item) {
/*            Item newitem = new Item(name, price, quantity);*/
              items.Add(item);
        }
        public void Displayitem() {
            Console.WriteLine("Items are :");
            foreach (Item item in items)
            {
                Console.WriteLine($"Item: {item.Name}, Price: ${item.Price}, Quantity: {item.Quantity}");
            }
        }
        public double calculatedamount() {
            double tamount= 0;
            foreach (Item item in items)
            {
                tamount += item.Quantity * item.Price;
            }
            return tamount;
            
        }
        public double totalamount{
            get { return calculatedamount(); }
        }
        
    }
}
