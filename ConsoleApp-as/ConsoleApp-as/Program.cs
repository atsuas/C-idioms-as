using System;

namespace ConsoleApp_as
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2016, 8, 20);
            int year = date.Year;

            //10日後をもとめる
            DateTime daysAfter10 = date.AddDays(10);
        }
    }
}
