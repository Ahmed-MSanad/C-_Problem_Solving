using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolvingInC_.Library_System
{
    internal class BorrowedBook : LibraryItem
    {
        // Use the Book struct to store details about the borrowed book.
        public Book BookDetails { get; set; }

        // Name of the person who borrowed the book.
        public string? BorrowerName { get; set; }

        // The date the book was borrowed.
        public DateTime BorrowedDate { get; set; }

        public BorrowedBook(Book bookDetails, string borrowerName, DateTime borrowedDate)
        {
            this.BookDetails = bookDetails;
            this.BorrowerName = borrowerName;
            this.BorrowedDate = borrowedDate;
        }

        public int CalculateBorrowDuration()
        {
            int numberOfBorrowedDays = (int)Math.Abs((DateTime.Now - this.BorrowedDate).TotalDays);

            return numberOfBorrowedDays;
        }
    }
}
