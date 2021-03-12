using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxlength = "";
            for (int i = 0; i < 3; i++)
            {
                var line = Console.ReadLine();
                var len = line.Length;
                if (len > maxlength.Length)
                {
                    maxlength = line;
                }
                
            }
            Console.WriteLine($"長い文字列は{maxlength}です");

        }
        
    }

}
