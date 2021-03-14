using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[4];
            var total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var line = Console.ReadLine();
                var number = int.Parse(line);
                total += number;
            }
            var average = total / nums.Length;
            Console.WriteLine(average);
        }
        
    }

}
