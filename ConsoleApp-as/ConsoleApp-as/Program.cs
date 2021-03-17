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
            var books = new List<Book>();
            books.Add(new Book("人間失格", "太宰治", 212, 5));
            books.Add(new Book("コスメの達人", "高橋尚子", 320, 4));
            books.Add(new Book("魚の骨", "水谷豊", 290, 3));
            books.Add(new Book("ご飯の飯", "太宰治", 188, 2));
            books.Add(new Book("総菜の元", "相川小", 329, 5));
            books.Add(new Book("食べるの好き", "権田けんいち", 242, 3));

            One(books);
            Console.WriteLine();

            Two(books);
            Console.WriteLine();

            Three(books);
            Console.WriteLine();

            Four(books);
            Console.WriteLine();



        }

        private static void One(List<Book> books)
        {
            var query = books.Where(x => x.Rate >= 4);
            foreach (var book in query)
            {
                Console.WriteLine($"{book.Title} {book.Author}");
            }
        }

        private static void Two(List<Book> books)
        {
            var query = books.OrderBy(x => x.Author);
            foreach (var book in query)
            {
                Console.WriteLine($"{book.Title} {book.Author}");
            }
        }

        private static void Three(List<Book> books)
        {
            var query = books.Where(x => x.Pages >= 300)
                             .ToArray();
            foreach (var book in query)
            {
                Console.WriteLine($"{book.Title} {book.Pages}");
            }

        }

        private static void Four(List<Book> books)
        {
            var query = books.OrderByDescending(x => x.Pages)
                             .First();

            Console.WriteLine($"{query.Title} {query.Pages}");
            
        }

    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rate { get; set; }

        public Book(string title, string author, int pages, int rate)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Rate = rate;
        }
    }

}
