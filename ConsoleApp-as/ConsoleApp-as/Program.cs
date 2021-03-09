using System;

namespace ConsoleApp_as
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "高田",
                Age = 16,
                Grade = 3,
                ClassNumber = 2
            };
            Console.WriteLine("{0}さんは、{1}歳で{2}年{3}組になりました",
                student.Name, student.Age, student.Grade, student.ClassNumber);

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

    public class Student : Person
    {
        public int Grade { get; set; }
        public int ClassNumber { get; set; }
    }
}
