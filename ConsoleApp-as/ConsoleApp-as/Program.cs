using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var count = int.Parse(line);
            for (int n = 0; n < count; n++)
            {
                var star = "*";
                for (int i = 0; i < n; i++)
                {
                    star += "*";
                }
                Console.WriteLine(star);
            }
        }
        
    }

}
