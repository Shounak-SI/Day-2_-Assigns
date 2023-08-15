using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarymanager
{
    internal class Book
    {
        public string Title;
        public string Author;
        public string Genre;
        public int Quantity;

        public Book() { }
        public Book(string Title,string Author, string Genre, int Quantity) { 
            this.Title = Title;
            this.Author = Author;
            this.Genre = Genre;
            this.Quantity = Quantity;
        }
        public override string ToString()
        {
            return $"Title : {Title}, Name : {Author}, Genre : {Genre}, Quantity : {Quantity}";
        }

        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                Book newbook = obj as Book;
                if (this.Title == newbook.Title || this.Author == newbook.Author) { return true; }
                else { return false; }
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Title,Author);
        }
    }
}
