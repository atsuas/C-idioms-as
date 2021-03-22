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
            var line1 = Console.ReadLine();
            var one = int.Parse(line1);
            Console.WriteLine();

            int a, b;
            string[] str = Console.ReadLine().Split(' ');
            a = int.Parse(str[0]);
            b = int.Parse(str[1]);
            var two = a + b;
            Console.WriteLine();

            var four = Console.ReadLine();

            var total = one + two;

            Console.WriteLine($"{total} {four}");

        }

    }

}

