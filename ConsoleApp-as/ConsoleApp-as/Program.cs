using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[5];
            var total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var line = Console.ReadLine();
                var num = int.Parse(line);
                total += num;
            }
            var average = total / nums.Length;
            Console.WriteLine(average);
        }
        
    }

}
