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
            var pets = new List<VirtualPet>
            {
                new FoodiePet("小太郎"),
                new CheerfulPet("元気"),
                new SleepyPet("眠太郎")
            };
            foreach (var pet in pets)
            {
                pet.Eat();
                pet.Play();
                Console.WriteLine($"{pet.Name} {pet.Mood} {pet.Energy}");
            }
        }
       
    }

    abstract class VirtualPet
    {
        public string Name { get; set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public VirtualPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public abstract void Eat();
        public abstract void Play();
        public abstract void Sleep();

    }

    class FoodiePet : VirtualPet
    {
        public FoodiePet(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Mood += 3;
            Energy += 5;
            Console.WriteLine("FoodiePet.Eatメソッドが実行されました");
        }

        public override void Play()
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("FoodiePet.Playメソッドが実行されました");
        }

        public override void Sleep()
        {
            Mood -= 1;
            Energy += 2;
            Console.WriteLine("FoodiePet.Sleepメソッドが実行されました");
        }
    }

    class CheerfulPet : VirtualPet
    {
        public CheerfulPet(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Mood += 0;
            Energy += 5;
            Console.WriteLine("Cheerful.Eatメソッドが実行されました");
        }

        public override void Play()
        {
            Mood += 3;
            Energy -= 12;
            Console.WriteLine("Cheerful.Playメソッドが実行されました");
        }

        public override void Sleep()
        {
            Mood -= 1;
            Energy += 4;
            Console.WriteLine("Cheerful.Sleepメソッドが実行されました");
        }
    }

    class SleepyPet : VirtualPet
    {
        public SleepyPet(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Mood -= 1;
            Energy += 5;
            Console.WriteLine("SleepyPet.Eatメソッドが実行されました");
        }

        public override void Play()
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("SleepyPet.Playメソッドが実行されました");
        }

        public override void Sleep()
        {
            Mood += 2;
            Energy += 4;
            Console.WriteLine("SleepyPet.Sleepメソッドが実行されました");
        }
    }

}
