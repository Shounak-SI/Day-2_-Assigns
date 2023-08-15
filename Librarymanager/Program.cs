namespace Librarymanager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library b1 = new Library();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Display book");
                Console.WriteLine("3. Search book and author");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Book Title: ");
                        string bTitle = Console.ReadLine();

                        Console.Write("Book Author: ");
                        string bName = Console.ReadLine();

                        Console.Write("Book Genre: ");
                        string bGenre = Console.ReadLine();

                        Console.Write("Book Quantity: ");
                        int bQuantity = Convert.ToInt32(Console.ReadLine());

                        Book newBook = new Book(bTitle, bName, bGenre, bQuantity);
                        b1.Addlibrary(newBook);
                        Console.WriteLine("Book added");
                        break;

                    case 2:
                        b1.Displaylibrary();
                        break;

                    case 3:
                        b1.SearchLibrary();
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