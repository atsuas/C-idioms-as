using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee
            {
                Id = 2,
                FamilyName = "又吉",
                GivenName = "けんじ",
                EmailAddress = "kennji@kennji.com"
            };

            var employee2 = new Employee
            {
                Id = 4,
                FamilyName = "香川",
                GivenName = "ようこ",
                EmailAddress = "youko@youko.com"
            };

            employee1.GetFullName();
            employee2.GetFullName();
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string EmailAddress { get; set; }

        public void GetFullName()
        {
            Console.WriteLine($"{FamilyName} {GivenName}");
        }

    }
}
