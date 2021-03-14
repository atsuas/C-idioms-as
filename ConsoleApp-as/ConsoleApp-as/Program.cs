using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "C#", "Ruby", "Kotlin", "Swift", "Python", "Java", "PHP" };
            var max = "";
            foreach (var name in names)
            {
                if (name.Length >= max.Length)
                {
                    max = name;
                }
            }
            Console.WriteLine(max);
        }
        
    }

}
