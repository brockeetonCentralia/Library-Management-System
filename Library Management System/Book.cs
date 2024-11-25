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

        public Book (string title, string author, string iSBN, int availableCopies)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            AvailableCopies = availableCopies;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}, ISBN: {ISBN}, Copies: {AvailableCopies}";
        }
    }
}
