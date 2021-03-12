using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var term = "";

            switch (word)
            {
                case "API":
                    term = "Application Programing Interface";
                    break;
                case "ROB":
                    term = "Relational Datebase";
                    break;
                case "UI":
                    term = "User Interface";
                    break;
                case "IDE":
                    term = "Integrated Development Environment";
                    break;
                case "HTML":
                    term = "HyperText Markup Language";
                    break;
            }
            if (term != "")
            {
                Console.WriteLine($"{word}の略は{term}です");
            }
        }
        
    }

}
