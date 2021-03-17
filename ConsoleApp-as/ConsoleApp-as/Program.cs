using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("生年月日を入力してください:");
            var line = Console.ReadLine();
            var comment = DateTime.Parse(line);
            if (comment.DayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("月曜日です");
            }
            else
            {
                Console.WriteLine("月曜日ではありません");
            }
        }

    }

}
