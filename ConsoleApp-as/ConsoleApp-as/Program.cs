using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字を入力してください:");
            var line = Console.ReadLine();
            if (line == "")
            {
                Console.WriteLine("空文字列です");
            }
            else
            {
                Console.WriteLine(line);
            }
            

        }
        
    }

}
