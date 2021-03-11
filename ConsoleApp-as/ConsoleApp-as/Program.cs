using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 20;
            Console.WriteLine($"a={a}, b={b}");

            var change = a;
            a = b;
            b = change;
            Console.WriteLine($"a={a}, b={b}");


        }
        
    }

}
