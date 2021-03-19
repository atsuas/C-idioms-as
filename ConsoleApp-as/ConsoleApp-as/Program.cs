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
            var pets = new List<IVirtualPet>
            {
                new FoodiePet("たかし"),
                new CheerfulPet("ことぶき"),
                new SleepyPet("かたぶし")
            };
            foreach (var pet in pets)
            {
                pet.Eat();
                pet.Play();
                pet.Sleep();
                pet.Rest();
                Console.WriteLine($"{pet.Name} {pet.Mood} {pet.Energy}");
            }
        }
       
    }

    interface IVirtualPet
    {
        string Name { get; }
        int Mood { get; set; }
        int Energy { get; set; }
        void Eat();
        void Play();
        void Sleep();
        void Rest();

    }

    class FoodiePet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public FoodiePet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public void Eat()
        {
            Mood += 3;
            Energy += 5;
            Console.WriteLine("FoodiePet.Eatメソッドが実行されました");
        }

        public void Play()
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("FoodiePet.Playメソッドが実行されました");
        }

        public void Sleep()
        {
            Mood -= 1;
            Energy += 2;
            Console.WriteLine("FoodiePet.Sleepメソッドが実行されました");
        }

        public void Rest()
        {
            Mood += 2;
            Energy += 4;
            Console.WriteLine("FoodiePet.Restメソッドが実行されました");
        }
    }

    class CheerfulPet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public CheerfulPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public void Eat()
        {
            Mood += 0;
            Energy += 5;
            Console.WriteLine("Cheerful.Eatメソッドが実行されました");
        }

        public void Play()
        {
            Mood += 3;
            Energy -= 12;
            Console.WriteLine("Cheerful.Playメソッドが実行されました");
        }

        public void Sleep()
        {
            Mood -= 1;
            Energy += 4;
            Console.WriteLine("Cheerful.Sleepメソッドが実行されました");
        }

        public void Rest()
        {
            Mood += 3;
            Energy += 5;
            Console.WriteLine("Cheerful.Restメソッドが実行されました");
        }
    }

    class SleepyPet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public SleepyPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public void Eat()
        {
            Mood -= 1;
            Energy += 5;
            Console.WriteLine("SleepyPet.Eatメソッドが実行されました");
        }

        public void Play()
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("SleepyPet.Playメソッドが実行されました");
        }

        public void Sleep()
        {
            Mood += 2;
            Energy += 4;
            Console.WriteLine("SleepyPet.Sleepメソッドが実行されました");
        }
        public void Rest()
        {
            Mood += 4;
            Energy += 6;
            Console.WriteLine("SleepyPet.Restメソッドが実行されました");
        }
    }

}
