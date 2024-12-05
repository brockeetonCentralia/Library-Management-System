using Library_Management_System;

Console.WriteLine("| Welcome to the Library Management System |");


LibraryDatabaseManagment libraryDatabaseManagment = new LibraryDatabaseManagment();
var bookSearchTree = new BookSearchTree();
List<User> users = new List<User>();

var book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "1234", 5);
var book2 = new Book("1984", "George Orwell", "2345", 2);
var book3 = new Book("To Kill a Mockingbird", "Harper Lee", "3456", 4);
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

bool running = true;

while (running)
{
    Console.WriteLine("\n---| Library Menu |---");
    Console.WriteLine("\n1. Display Catalog ");
    Console.WriteLine("2. Search for a Book by ISBN");
    Console.WriteLine("3. Borrow A Book ");
    Console.WriteLine("4. Return A Book ");
    Console.WriteLine("5. View Borrowing History ");
    Console.WriteLine("6. Exit");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("---| Catalog |---");
            libraryDatabaseManagment.DisplayCatalog();
            break;

        case "2":
            Console.WriteLine("Enter ISBN of book you would like to search: ");
            string searchISBN = Console.ReadLine();

            var searchedBook = bookSearchTree.SearchByISBN(searchISBN);

            if (searchedBook != null)
            {
                Console.WriteLine($"\nBook Found: {searchedBook}");
            }
            else
            {
                Console.WriteLine($"\nNo book found with ISBN: {searchISBN}");
            }
        break;

        case "3":
            BorrowBook();
            break;

        case "4":
            _ReturnBook(); 
            break;

        case "5":
            ViewBorrowing();
            break;

        case "6":
            Console.WriteLine("Exiting the system. Goodbye!");
            running = false;
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}


void BorrowBook()
{
    Console.WriteLine("\nEnter your Name: ");
    string userName = Console.ReadLine();
    User user = users.Find(u => u.Name == userName) ?? new User(userName);

    if (!users.Contains(user)) users.Add(user);

    Console.WriteLine("Enter ISBN of book to borrow: ");
    string isbn = Console.ReadLine();

    var book = bookSearchTree.SearchByISBN(isbn);

    if (book != null)
    {
        user.BorrowBook(book);
    }
    else
    {
        Console.WriteLine($"\nNo book found with ISBN: {isbn}");
    }
}

void _ReturnBook()
{
    Console.WriteLine("\nEnter your Name: ");
    string userName = Console.ReadLine();

    User user = users.Find(u => u.Name == userName);

    if (user != null)
    {
        user.ReturnBook();
    }
    else
    {
        Console.WriteLine("No user with that name");
    }
}

void ViewBorrowing()
{
    Console.WriteLine("\nEnter your Name: ");
    string userName = Console.ReadLine();

    User user = users.Find(u => u.Name == userName);

    if (user != null)
    {
        user.ViewBorrowoingHistory();
    }
    else
    {
        Console.WriteLine("No user with that name");
    }
}






//bookSearchTree.DisplayInOrder();

//var user = new User("Broc");
//var user2 = new User("John");
//var user3 = new User("Lane");

//user1.BorrowBook(book2);
//user2.BorrowBook(book2);
//user3.BorrowBook(book2);
//user1.BorrowBook(book4);
//user2.BorrowBook(book3);
//user3.BorrowBook(book3);

//libraryDatabaseManagment.DisplayCatalog();

//user1.ViewBorrowoingHistory();
//user2.ViewBorrowoingHistory();
//user3.ViewBorrowoingHistory();

//user1.ReturnBook(book2);
//user2.ReturnBook(book2);
//user2.ReturnBook(book3);
//user3.ReturnBook(book3);

//user1.ViewBorrowoingHistory();
//user2.ViewBorrowoingHistory();
//user3.ViewBorrowoingHistory();

//libraryDatabaseManagment.DisplayCatalog();