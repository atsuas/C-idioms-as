using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力：");
            var line = Console.ReadLine();
            var num = int.Parse(line);
            if ((num % 3 == 0) && (num % 5 == 0))
            {
                Console.WriteLine("numは3でも5でも割り切れます");
            }
            else
            {
                Console.WriteLine("違う数値を入力してください");
            }
        }
        
    }

}
