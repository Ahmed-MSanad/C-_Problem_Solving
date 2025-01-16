using System;
using LeetCodeSolvingInC_.Library_System;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace LeetCodeSolvingInC_
{
    /*
     ********************* Library Management System *********************
     Scenario: 
        A library management system needs a basic implementation to handle books and their associated borrowing details. 
        You need to design a solution using classes, structs, inheritance, and functions.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            BorrowedBook[] availableBooksToBeBorrowed = new BorrowedBook[] {
                new BorrowedBook(new Book("Clean Code", "Robert C. Martin", "978-0-19-872832-3"), "", DateTime.Now),
                new BorrowedBook(new Book("The Pragmatic Programmer", "Andrew Hunt, David Thomas", "978-0-201616224"), "", DateTime.Now),
                new BorrowedBook(new Book("Code Complete", "Steve McConnell", "978-0735619670"), "", DateTime.Now),
                new BorrowedBook(new Book("Refactoring: Improving the Design of Existing Code", "Martin Fowler", "978-0201485677"), "", DateTime.Now),
                new BorrowedBook(new Book("Design Patterns: Elements of Reusable Object-Oriented Software", "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", "978-0201633610"), "", DateTime.Now),
                new BorrowedBook(new Book("The Mythical Man-Month", "Frederick Brooks", "978-0201835953"), "", DateTime.Now),
                new BorrowedBook(new Book("Introduction to Algorithms", "Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, Clifford Stein", "978-0262033848"), "", DateTime.Now),
                new BorrowedBook(new Book("Effective Java", "Joshua Bloch", "978-0134685991"), "", DateTime.Now),
                new BorrowedBook(new Book("Head First Design Patterns", "Eric Freeman, Elisabeth Robson, Bert Bates, Kathy Sierra", "978-0596007126"), "", DateTime.Now),
                new BorrowedBook(new Book("Domain-Driven Design: Tackling Complexity in the Heart of Software", "Eric Evans", "978-0321125217"), "", DateTime.Now),
            };

            Console.WriteLine("\n====================== Welcome to Our Library System ======================");
            Console.WriteLine("================== ================== ================== ==================\n");

            while (true)
            {
                Console.WriteLine("********************* Please Follow the Instructions *********************");

                byte choice;
                do
                {
                    Console.WriteLine("Click 1 to borrow a book OR 0 to return a Book.");
                } while (!byte.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 0));

                if (choice == 1)
                {
                    string userName;
                    do
                    {
                        Console.WriteLine("Enter Your Name please: ");
                        userName = Console.ReadLine();
                    } while (string.IsNullOrEmpty(userName));

                    int bookChoice = ChoseBookToBorrow(availableBooksToBeBorrowed);
                    availableBooksToBeBorrowed[bookChoice].CheckOut();
                    availableBooksToBeBorrowed[bookChoice].BorrowerName = userName;
                    availableBooksToBeBorrowed[bookChoice].BorrowedDate = DateTime.Now;

                    Console.WriteLine($"Book Title : {availableBooksToBeBorrowed[bookChoice].BookDetails.Title} - Book Author : {availableBooksToBeBorrowed[bookChoice].BookDetails.Author} has been reserved for you Mr.{userName} at {DateTime.Now}");
                    SayGoodBey();
                }
                else{
                    string bookISBN;
                    do
                    {
                        Console.WriteLine("Enter the Book International Standard Number: ");
                        bookISBN = Console.ReadLine();
                    } while (string.IsNullOrEmpty(bookISBN));

                    int bookIndex = GetBookWithISBN(availableBooksToBeBorrowed, bookISBN);
                    if (bookIndex != -1)
                    {
                        availableBooksToBeBorrowed[bookIndex].BorrowerName = "";
                        availableBooksToBeBorrowed[bookIndex].ReturnItem();
                        Console.WriteLine($"Book Title : {availableBooksToBeBorrowed[bookIndex].BookDetails.Title} - Book Author : {availableBooksToBeBorrowed[bookIndex].BookDetails.Author} has been reserved returned successfuly after has been borrowed for {availableBooksToBeBorrowed[bookIndex].CalculateBorrowDuration()} Days");
                        SayGoodBey();
                    }
                    else
                    {
                        Console.WriteLine("Wrong ISBN !!");
                        SayGoodBey();
                    }
                }
            }
        }
        static int ChoseBookToBorrow(BorrowedBook[] availableBooks)
        {
            Console.WriteLine("Chose a Book by clicking the book number: ");
            for (int bookIndex = 0; bookIndex < availableBooks.Length; bookIndex++) {
                if (availableBooks[bookIndex].IsAvailable)
                {
                    Console.WriteLine($"{bookIndex+1}) Book Title : {availableBooks[bookIndex].BookDetails.Title} - Book Author : {availableBooks[bookIndex].BookDetails.Author}");
                }
            }
            int bookChoice;
            do
            {
                Console.WriteLine("Which Book Would Like to Borrow: ");
            }while(!int.TryParse(Console.ReadLine(), out bookChoice) && bookChoice >= 1 && bookChoice <= availableBooks.Length);

            return bookChoice-1;
        }

        static int GetBookWithISBN(BorrowedBook[] availableBooks, string bookISBN)
        {
            for (int bookIndex = 0; bookIndex < availableBooks.Length; bookIndex++)
            {
                if (availableBooks[bookIndex].BookDetails.ISBN == bookISBN)
                {
                    return bookIndex;
                }
            }
            return -1;
        }
    
        static void SayGoodBey()
        {
            Console.WriteLine("\n======================================================================");
            Console.WriteLine("We're So Happy to Serve You Sir,,,..");
            Console.WriteLine("======================================================================\n");
        }
    }
}
