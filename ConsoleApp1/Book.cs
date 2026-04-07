using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book()
        {
            Console.WriteLine("Creating book"); 
        }
        public Book(string atitle, string aauthor, int apages)
        {
            this.title = atitle;
            this.author = aauthor;
            this.pages = apages;
        }
    }
}
