using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力してください：");
            var line = Console.ReadLine();
            var num = int.Parse(line);
            if (num < 0 || num > 100)
            {
                Console.WriteLine("入力値が誤っています");
            }
            else if (num <= 30)
            {
                Console.WriteLine("不可");
            }
            else if (num <= 60)
            {
                Console.WriteLine("可");
            }
            else if (num <= 80)
            {
                Console.WriteLine("良");
            }
            else if (num <= 100)
            {
                Console.WriteLine("優");
            }

        }
        
    }

}
