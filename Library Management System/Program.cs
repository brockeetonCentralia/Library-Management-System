using Library_Management_System;

Console.WriteLine("| Welcome to the Library Management System |");


LibraryDatabaseManagment libraryDatabaseManagment = new LibraryDatabaseManagment();

libraryDatabaseManagment.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "1234", 5));
libraryDatabaseManagment.AddBook(new Book("1984", "George Orwell", "2345", 2));
libraryDatabaseManagment.DisplayCatalog();
libraryDatabaseManagment.RemoveBook("1234");
libraryDatabaseManagment.DisplayCatalog();
