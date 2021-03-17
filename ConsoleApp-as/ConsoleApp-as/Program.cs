using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("小林", "たかし", Gender.Femele);
            Console.WriteLine($"{person.FirstName} {person.LastName} {person.Gender}");
        }

    }

    enum Gender
    {
        Male,
        Femele
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Gender Gender { get; set; }
        public string Fullname
        {
            get { return LastName + FirstName; }
        }

        public Person()
        {
            FirstName = "";
            LastName = "";
        }

        public Person(string firstName, string lastName, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }
    }

}
