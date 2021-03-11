using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("購入金額：");
            var line = Console.ReadLine();
            var product = int.Parse(line);
            var point = product * 0.05;
            Console.WriteLine($"ポイント5倍day!! {point}pointです");

        }
        
    }

}
