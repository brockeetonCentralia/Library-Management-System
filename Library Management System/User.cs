using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class User
    {
        public string Name { get; set; }
        public Stack<Book> BorrowingHistory { get; set; }

        public User(string name)
        {
            Name = name;
            BorrowingHistory = new Stack<Book>();
        }

        public bool BorrowBook(Book book)
        {
            if (book.AvailableCopies > 0)
            {
                BorrowingHistory.Push(book);
                book.AvailableCopies--;
                Console.WriteLine($"{Name} borrowed: {book.Title}");
                return true;
            }
            else
            {
                Console.WriteLine($"{book.Title} is currently unavailable.");
                book.AddToWaitList(Name);
                return false;
            }
        }
        
        public bool ReturnBook()
        {
            if (BorrowingHistory.Count > 0)
            {
                Book book = BorrowingHistory.Pop();
                book.AvailableCopies++;
                Console.WriteLine($"{Name} returned: {book.Title}");

                string nextUser = book.NotifyNextInWaitlist();
                if (nextUser != null)
                {
                    Console.WriteLine($"Notification sent to: {nextUser}");
                }

                return true;

            }
            else
            {
                Console.WriteLine($"{Name} has no books to return.");
                return false;
            }
        }

        public void ViewBorrowoingHistory()
        {
            Console.WriteLine($"\n{Name}'s Borrowing History:");
            if (BorrowingHistory.Count == 0)
            {
                Console.WriteLine("No books borrowed.");
            }
            else
            {
                foreach (var book in BorrowingHistory)
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}
