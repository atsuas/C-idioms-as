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
            while (true)
            {
                try
                {
                    var total = 1000;
                    var line = Console.ReadLine();
                    var count = int.Parse(line);
                    var ans = total / count;
                    Console.WriteLine(ans);
                    Console.WriteLine("正常終了");
                    break;
                }
                catch
                {
                    Console.WriteLine("入力した値が正しくありません。再度入力してください。");
                }
            }
        }

        private static void Two()
        {
            while (true)
            {
                var total = 1000;
                var line = Console.ReadLine();
                if (int.TryParse(line, out var count))
                {
                    var ans = total / count;
                    Console.WriteLine(ans);
                    Console.WriteLine("seijousyuuryou");
                    break;
                }
                else
                {
                    Console.WriteLine("入力値が間違っています。再度入力してください");
                }
                
            }
        }
    }

}

