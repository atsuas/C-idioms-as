using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = new int[] { 10, 30, 50, 60, 90, 20, 10, 44 };
            var max = ArrayUnit.Max(scores);
            var min = ArrayUnit.Min(scores);
            Console.WriteLine($"最大値：{max} 最小値：{min}");
            
        }
    }

    static class ArrayUnit
    {
        public static int Total(int[] numbers)
        {
            var total = 0;
            foreach (var num in numbers)
            {
                total += num;
            }
            return total;
        }

        public static double Average(int[] numbers)
        {
            var total = Total(numbers);
            return (double)total / numbers.Length;
        }

        public static int Max(int[] numbers)
        {
            var max = numbers[0];
            foreach (var num in numbers)
            {
                if (max < num)
                {
                    max = num;
                }
            }
            return max;
            
        }

        public static int Min(int[] numbers)
        {
            var min = numbers[0];
            foreach (var num in numbers)
            {
                if (min > num)
                {
                    min = num;
                }
            }
            return min;

        }
    }
}
