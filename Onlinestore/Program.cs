namespace Onlinestore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Product to store");
                Console.WriteLine("2. Display Product");
                Console.WriteLine("3. Calculate total value of product");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Product Name: ");
                        string productName = Console.ReadLine();

                        Console.Write("Price: ");
                        double productPrice = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Quantity: ");
                        int productQuantity = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Category: ");
                        string productcategory = Console.ReadLine();

                        Product newProduct = new Product(productName, productPrice, productQuantity, productcategory);
                        store.AddProduct(newProduct);
                        Console.WriteLine("Item added to cart.");
                        break;

                    case 2:
                        store.Displayproduct();
                        break;

                    case 3:
                        Console.WriteLine($"Total Cost: ${store.Calculateamount()}");
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