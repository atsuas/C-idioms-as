using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            for (int num = 0; num <= 500; num++)
            {
                if (((num % 3 == 0) || (num % 7 == 0)) && (num % 2 == 1))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        
    }

}
