using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 0;
            while (num >= 0)
            {
                Console.Write("正の数を入力してください：");
                var line = Console.ReadLine();
                num = int.Parse(line);

                if (num < 0)
                {
                    Console.WriteLine("処理を抜けます");
                    break;
                }
            }
            Console.WriteLine($"{num}が入力されました");
        }
        
    }

}
