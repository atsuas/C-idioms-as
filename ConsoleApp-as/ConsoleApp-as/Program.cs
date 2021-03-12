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
            var number = int.Parse(line);
            if (number > 0)
            {
                Console.WriteLine("正数です");
            }
            else if (number < 0)
            {
                Console.WriteLine("負数です");
            }
            else
            {
                Console.WriteLine(number);
            }

        }
        
    }

}
