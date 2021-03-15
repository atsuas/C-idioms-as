using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayday = Date();
            Console.WriteLine(dayday);

            TheDay();
        }

        public static int Date()
        {
            var month = DateTime.DaysInMonth(2021, 2);
            return month;
        }

        public static void TheDay()
        {
            var line = Console.ReadLine();
            var days = DateTime.Parse(line);
            var week = days.ToString("ddd");
            Console.WriteLine($"{week}");
        }
    }

    
}
