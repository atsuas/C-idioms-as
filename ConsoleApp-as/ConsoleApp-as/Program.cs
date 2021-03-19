using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DistanceConverter
{
    class Program
    {
        static void Main()
        {
            object book = new Book("人間失格", "太宰治", 450, 4);
            Console.WriteLine(book);
            //Console.WriteLine(book.ToString());
        }
       
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }
        public Book(string title, string author, int pages, int rating)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Rating = rating;
        }

        public override string ToString()
        {
            var s = $"{Title} {Author} {Pages} {Rating}";
            return s;
        }

    }

}
