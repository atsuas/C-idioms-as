using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmicalc = BmiCalculator.GetBmi(180, 90);
            var body = BmiCalculator.GetBodyType(bmicalc);
            Console.WriteLine("あなたのBMIは{0}、タイプは{1}です", bmicalc, body);
        }
    }

    static class BmiCalculator
    {
        public static double GetBmi(double height, double weight)
        {
            var meterTall = height / 100.0;
            var bmi = weight / (meterTall * meterTall);
            return bmi;
        }

        public static string GetBodyType(double bmi)
        {
            var type = "";
            if (bmi < 18.5)
            {
                type = "瘦せ型";
            }
            else if (bmi < 25)
            {
                type = "普通体重";
            }
            else if (bmi < 30)
            {
                type = "肥満1度";
            }
            else if (bmi < 35)
            {
                type = "肥満2度";
            }
            else if (bmi < 40)
            {
                type = "肥満3度";
            }
            else
            {
                type = "肥満4度";
            }
            return type;
        }
    }
}
