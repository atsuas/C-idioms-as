using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 10, 20, 30, 8, 84 };
            Console.WriteLine(ArrayUtils.GetMin(nums, true));
            Console.WriteLine(ArrayUtils.GetMin(nums));
        }

    }

    static class ArrayUtils
    {
        
        public static int GetMin(int[] numbers, bool isPosition = false)
        {
            var min = int.MaxValue;
            foreach (var n in numbers)
            {
                if (isPosition && n <= 0)
                {
                    continue;
                }
                min = Math.Min(min, n);
            }
            return min;
        }
        
    }
}
