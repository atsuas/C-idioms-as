using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main()
        {
            var dates = new List<DateTime>
            {
                new DateTime(2000,11, 8, 12, 8, 0),
                new DateTime(2020, 8, 4,23, 6, 0),
                new DateTime(2010, 4, 5, 8, 1, 0),
                new DateTime(2018,12,12,10,13, 0),
                new DateTime(2016, 3,18,15,35, 0),
                new DateTime(2014, 4, 1,18,46, 0)
            };

            var count = dates.Count;
            Console.WriteLine(count);

            foreach (var n in dates)
            {
                Console.WriteLine(n.ToString("yyyy年mm月dd日 HH:mm"));
            }

            



        }

    }



}
