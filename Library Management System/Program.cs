using Library_Management_System;

Console.WriteLine("| Welcome to the Library Management System |");


LibraryDatabaseManagment libraryDatabaseManagment = new LibraryDatabaseManagment();

var book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "1234", 5);
var book2 = new Book("1984", "George Orwell", "2345", 2);
var book3 = new Book("To Kill a MockingBird", "Harper Lee", "3456", 4);
var book4 = new Book("War and Peace", "Leo Tolstoy", "4567", 3);

libraryDatabaseManagment.AddBook(book1);
libraryDatabaseManagment.AddBook(book2);
libraryDatabaseManagment.AddBook(book3);
libraryDatabaseManagment.AddBook(book4);
libraryDatabaseManagment.DisplayCatalog();
libraryDatabaseManagment.RemoveBook("1234");
libraryDatabaseManagment.DisplayCatalog();

var user = new User("Broc");

user.BorrowBook(book1);
