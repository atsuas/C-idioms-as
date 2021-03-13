using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxlen = "";
            for (int i = 0; i < 3; i++)
            {
                var text = Console.ReadLine();
                var len = text.Length;
                if (len > maxlen.Length)
                {
                    maxlen = text;
                }
                
            }
            Console.WriteLine(maxlen);
        }
        
    }

}
