using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 8;
            x /= 2;
            Console.WriteLine(x); //4

            var a = 4;
            var b = 6;
            a += b * 2;
            Console.WriteLine(a); //16

            var n = 5;
            var k = 3;
            n *= (k + 4);
            Console.WriteLine(n); //35

        }
        
    }

}
