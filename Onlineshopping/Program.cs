namespace Onlineshopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Shoppingcart cart = new Shoppingcart();
            cart.Additem("Item 1", 10.99, 2);
            cart.Additem("Item 2", 5.75, 3);
            cart.Additem("Item 3", 8.50, 1);
            cart.Displayitem();
            Console.WriteLine($"total amount : ${cart.totalamount}");*/
            Shoppingcart cart = new Shoppingcart();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add item to cart");
                Console.WriteLine("2. Display cart contents");
                Console.WriteLine("3. Calculate total cost");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Item Name: ");
                        string itemName = Console.ReadLine();

                        Console.Write("Price: ");
                        double itemPrice = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Quantity: ");
                        int itemQuantity = Convert.ToInt32(Console.ReadLine());

                        Item newItem = new Item(itemName, itemPrice, itemQuantity);
                        cart.Additem(newItem);
                        Console.WriteLine("Item added to cart.");
                        break;

                    case 2:
                        cart.Displayitem();
                        break;

                    case 3:
                        Console.WriteLine($"Total Cost: ${cart.totalamount}");
                        break;

                    case 4:
                        Console.WriteLine("Exiting program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please choose again.");
                        break;
                }
            }

        }
    }
}