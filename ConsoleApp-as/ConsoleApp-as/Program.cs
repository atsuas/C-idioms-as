using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine();
            var line2 = Console.ReadLine();
            var num1 = int.Parse(line1);
            var num2 = int.Parse(line2);
            var min = Math.Min(num1, num2);
            Console.WriteLine(min);

        }
    }

    
}
