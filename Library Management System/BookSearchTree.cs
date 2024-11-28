using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class BookSearchTree
    {
        public TreeNode Root { get; set; }
        public void AddBook(Book book)
        {
            Root = AddBookRecursive(Root, book);
        }
        private TreeNode AddBookRecursive(TreeNode node, Book book)
        {
            if (node == null)
            {
                return new TreeNode(book);
            }

            if (string.Compare(book.ISBN, node.Book.ISBN) < 0)
            {
                node.Left = AddBookRecursive(node.Left, book);
            }
            else if(string.Compare(book.ISBN, node.Book.ISBN) > 0) 
            {
                node.Right = AddBookRecursive(node.Right, book); 
            }
            return node;
        }
        public Book SearchByISBN(string isbn)
        {
            return SearchByISBNRecursive(Root, isbn);   
        }
        private Book SearchByISBNRecursive(TreeNode node, string isbn)
        {
            if (node == null)
            {
                return null;
            }
            if (isbn == node.Book.ISBN)
            {
                return node.Book;
            }
            if (string.Compare(isbn, node.Book.ISBN) < 0)
            {
                return SearchByISBNRecursive(node.Left, isbn);
            }
            return SearchByISBNRecursive(node.Right, isbn);
        }
        public void DisplayInOrder()
        {
            Console.WriteLine("\nBooks in Catalog (sorted by ISBN): ");
            InOrderTraversal(Root);
        }
        private void InOrderTraversal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            InOrderTraversal(node.Left);
            Console.WriteLine(node.Book);
            InOrderTraversal(node.Right);
        }
    }
}
