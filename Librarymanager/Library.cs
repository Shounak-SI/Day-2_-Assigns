using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarymanager
{
    internal class Library
    {
        List<Book> books;

        public Library() { 
            books = new List<Book>();
        }

        public void Addlibrary(Book book)
        {
            books.Add(book);
        }

        public void Displaylibrary() {
            Console.WriteLine("List of Books:");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void SearchLibrary()
        {
            Console.WriteLine("Enter Title and Author of Book");
            string input = Console.ReadLine();
            foreach(Book b in books)
            {
                if(input.Equals(b.Title)||input.Equals(b.Author))
                {
                     Console.WriteLine(b);
                }
                else { Console.WriteLine("Not Found"); }
            }
            
        }

    }
}
