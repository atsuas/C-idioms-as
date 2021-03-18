using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DistanceConverter
{
    class Program
    {
        static void Main()
        {
            var num = new int[] { 20, -10, 42, 56, 11, -4 };
            Console.WriteLine(ArrayUtil.GetMin(num, true));
            Console.WriteLine(ArrayUtil.GetMin(num));
        }
       
    }

    class ArrayUtil
    {
        public static int GetMin(int[] number, bool isPosition = false)
        {
            var min = int.MaxValue;
            foreach (var n in number)
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
