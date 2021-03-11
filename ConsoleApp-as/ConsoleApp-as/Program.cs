using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = 100;
            var n2 = 13;
            var a1 = n1 + n2; //113
            var a2 = -n1 / n2; //-7
            var a3 = (double)n1 / n2; //7.692307692307692
            var a4 = a2 - n1; //-107
            var a5 = a3 * -2; //-15.38461538461538
            var a6 = a4 * 2.0M; //-216

            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
            Console.WriteLine(a5);
            Console.WriteLine(a6);
        }
        
    }

}
