using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int AvailableCopies { get; set; }
        public Queue<string> Waitlist { get; set; }

        public Book (string title, string author, string iSBN, int availableCopies)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            AvailableCopies = availableCopies;
            Waitlist = new Queue<string>();
        }

        public void AddToWaitList(string userName)
        {
            Waitlist.Enqueue(userName);
            Console.WriteLine($"{userName} added to waitlist for {Title}");
        }

        public string NotifyNextInWaitlist()
        {
            if ( Waitlist.Count > 0 )
            {
                string nextUser =  Waitlist.Dequeue();
                Console.WriteLine($"Notified {nextUser}: A copy of  {Title} is now available.");
                return nextUser;
            }
            return null;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}, ISBN: {ISBN}, Copies: {AvailableCopies}";
        }
    }
}
