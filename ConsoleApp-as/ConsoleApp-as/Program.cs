using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

    }

    static class ArrayUtils
    {
        public static int Total(int[] numbers)
        {
            var total = 0;
            foreach (var n in numbers)
            {
                total += n;
            }
            return total;
        }

        public static double Average(int[] numbers)
        {
            var total = Total(numbers);
            return (double)total / numbers.Length;
        }

        public static int GetMin(int[] isPosition)
        {

        }
    }
}
