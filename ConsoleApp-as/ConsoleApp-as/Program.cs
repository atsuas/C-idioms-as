using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("金額を入力してください：");
            var line = Console.ReadLine();
            var price = int.Parse(line);
            var tax = 1.1;
            var totalPrice = (int)(price * tax);
            Console.WriteLine("商品価格は{0}円です", totalPrice);

        }
        
    }

}
