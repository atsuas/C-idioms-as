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
            var b = 5;
            Console.WriteLine($"a={a}, b={b}");
            var temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a={a}, b={b}");


        }
        
    }

}
