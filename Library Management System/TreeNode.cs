using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class TreeNode
    {
        public Book Book { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode(Book book)
        {
            Book = book;
            Left = null;
            Right = null;
        }
    }
}
