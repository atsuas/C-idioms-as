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
            One();
            Two();
        }

        private static void One()
        {
            var sw = new StreamWriter("sample.txt");
            try
            {
                sw.WriteLine("吾輩は猫である");
                sw.WriteLine("名前はまだない");
                sw.WriteLine("どこで生まれたんかとんと見当がつかぬ");
            }
            finally
            {
                sw.Dispose();
            }
        }

        private static void Two()
        {
            using (var sw = new StreamWriter("sample2.txt"))
            {
                sw.WriteLine("吾輩は猫である");
                sw.WriteLine("名前はまだない");
                sw.WriteLine("どこで生まれたんかとんと見当がつかぬ");
            }
        }

    }

}

