using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolvingInC_.Library_System
{
    internal struct Book
    {
        string title;
        public string Title { get => title; set => title = (value.Length <= 100) ? value : "No Title"; }

        string author;
        public string Author { get => author; set => author = (value.Length <= 100) ? value : "Unkown Author Name"; }

        string isbn;
        public string ISBN { get => isbn; set => isbn = (value.Length <= 100) ? value : "No Correct ISBN is Specified Yet!!"; }

        public Book(string title, string author, string isbn)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
        }
    }
}
