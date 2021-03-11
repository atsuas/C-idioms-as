using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var kilometers_per_hour = 54;
            var hour = 3;
            var kilometer = kilometers_per_hour * hour;
            Console.WriteLine(kilometer);

        }
        
    }

}
