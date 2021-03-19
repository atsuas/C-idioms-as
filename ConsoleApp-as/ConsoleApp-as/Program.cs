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
            var customer = new Customer
            {
                FirstName = "高橋",
                LastName = "ジョージ",
                Email = "example@example.com",
                BirthDay = new DateTime(2020, 8, 17)
            };
            Console.WriteLine($"{customer.FullName} {customer.Email} {customer.BirthDay}");

            var employee = new Employee
            {
                FirstName = "小林",
                LastName = "たかし",
                Email = "takashi@example.com",
                BirthDay = new DateTime(2021, 5, 24)
            };
            Console.WriteLine($"{employee.FullName} {employee.Email} {employee.BirthDay}");
        }
       
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName 
        {
            get { return FirstName + LastName; } 
        }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }

    }
    
    class Customer : Person
    {
        public string ID { get; set; }
        public int Rank { get; set; }
        public int CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int Number { get; set; }
        public DateTime HireDate { get; set; }

        public override string ToString()
        {
            var s = $"{Number} {FullName}" +
                    $"{HireDate.Year}年{HireDate.Month}月{HireDate.Day}日";
            return s;
        }
    }
}
