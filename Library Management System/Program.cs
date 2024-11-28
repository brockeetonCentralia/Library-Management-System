using Library_Management_System;

Console.WriteLine("| Welcome to the Library Management System |");


LibraryDatabaseManagment libraryDatabaseManagment = new LibraryDatabaseManagment();
var bookSearchTree = new BookSearchTree();

var book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "1234", 5);
var book2 = new Book("1984", "George Orwell", "2345", 2);
var book3 = new Book("To Kill a MockingBird", "Harper Lee", "3456", 4);
var book4 = new Book("War and Peace", "Leo Tolstoy", "4567", 3);

libraryDatabaseManagment.AddBook(book1);
libraryDatabaseManagment.AddBook(book2);
libraryDatabaseManagment.AddBook(book3);
libraryDatabaseManagment.AddBook(book4);
//libraryDatabaseManagment.DisplayCatalog();
////libraryDatabaseManagment.RemoveBook("1234");
//libraryDatabaseManagment.DisplayCatalog();

bookSearchTree.AddBook(book1);
bookSearchTree.AddBook(book2);
bookSearchTree.AddBook(book3);
bookSearchTree.AddBook(book4);
bookSearchTree.DisplayInOrder();

var user1 = new User("Broc");
var user2 = new User("John");
var user3 = new User("Lane");

user1.BorrowBook(book2);
user2.BorrowBook(book2);
user3.BorrowBook(book2);
user1.BorrowBook(book4);
user2.BorrowBook(book3);
user3.BorrowBook(book3);

libraryDatabaseManagment.DisplayCatalog();

user1.ViewBorrowoingHistory();
user2.ViewBorrowoingHistory();
user3.ViewBorrowoingHistory();

user1.ReturnBook(book2);
user2.ReturnBook(book2);
user2.ReturnBook(book3);
user3.ReturnBook(book3);

user1.ViewBorrowoingHistory();
user2.ViewBorrowoingHistory();
user3.ViewBorrowoingHistory();

libraryDatabaseManagment.DisplayCatalog();