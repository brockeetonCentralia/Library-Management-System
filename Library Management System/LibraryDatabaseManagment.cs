using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class LibraryDatabaseManagment
    {
        static LinkedList<Book> libraryCatalog = new LinkedList<Book>();

        public void AddBook(Book book)
        {
            libraryCatalog.AddLast(book);
            //Console.WriteLine($"\nAdded: {book}");
        }

        public void RemoveBook(string isbn)
        {
            LinkedListNode<Book> currentBook = libraryCatalog.First;

            while ( currentBook != null )
            {
                if ( currentBook.Value.ISBN == isbn )
                {
                    libraryCatalog.Remove(currentBook);
                    Console.WriteLine($"\nRemoved book with ISBN: {isbn}");
                    return;
                }
                currentBook = currentBook.Next;
            }
            Console.WriteLine($"\nNo book found with ISBN: {isbn}");
        }

        public void DisplayCatalog()
        {
            Console.WriteLine("\nLibrary Catalog: ");
            if ( libraryCatalog.Count == 0 )
            {
                Console.WriteLine("Catalog Empty");
            }
            else
            {
                foreach ( var  book in libraryCatalog )
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}
