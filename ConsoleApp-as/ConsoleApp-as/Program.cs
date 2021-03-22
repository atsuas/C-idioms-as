using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
            {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

        }

        private static void Exercise1_1(List<int> numbers)
        {
            var exist = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
            if (exist)
                Console.WriteLine("存在しています");
            else
                Console.WriteLine("存在していません");
        }
    }

}

