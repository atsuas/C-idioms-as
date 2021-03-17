using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("風の谷のナウシカ", "小林")
            {
                Pages = 380,
                Rate = 5
            };
            book.Print();

        }

    }

    class Book
    {
        public Book(string title, string auther)
        {
            Title = title;
            Auther = auther;
        }

        public string Title { get; set; }
        public string Auther { get; set; }
        public int Pages { get; set; }
        public int Rate { get; set; }

        public void Print()
        {
            Console.WriteLine($"タイトル：{Title} 著者：{Auther} ページ数：{Pages} 評価：{Rate}");
        }

    }
}
