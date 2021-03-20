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
            //One();

            Two();
        }
        private static void One()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(array[5]);
        }

        private static void Two()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };

            try
            {
                Console.WriteLine(array[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}

