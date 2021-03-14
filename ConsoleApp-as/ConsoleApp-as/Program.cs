using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[20];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = 100 + i;
            }
            foreach (var n in nums)
            {
                Console.WriteLine(n);
            }
        }
        
    }

}
