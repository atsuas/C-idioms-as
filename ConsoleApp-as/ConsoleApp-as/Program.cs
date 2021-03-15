using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book
            {
                Title = "猫の恩返し",
                Auther = "高橋",
                Pages = 370,
                Rate = 4,
                Memo = "おもしろい"
            };

            var book2 = new Book
            {
                Title = "魚物語",
                Auther = "小林",
                Pages = 290,
                Rate = 5,
                Memo = "まあまあ"
            };

            book1.Print();
            book2.Print();
            
            
        }
        
    }

    class Book
    {
        public string Title { get; set; }
        public string Auther { get; set; }
        public int Pages { get; set; }
        public int Rate { get; set; }
        public string Memo { get; set; }

        public void Print()
        {
            Console.WriteLine($"タイトル：{Title}");
            Console.WriteLine($"著者：{Auther}, ページ数：{Pages},レート：{Rate}, メモ：{Memo}");
        }
    }

}
