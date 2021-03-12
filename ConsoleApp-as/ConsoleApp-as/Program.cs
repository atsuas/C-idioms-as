using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxline = "";
            for (int i = 0; i < 5; i++)
            {
                Console.Write("文字を入力してください：");
                var line = Console.ReadLine();
                var len = line.Length;
                if (len > maxline.Length)
                {
                    maxline = line;
                }
            }
            Console.WriteLine(maxline);
        }
        
    }

}
