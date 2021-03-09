using System;

namespace ConsoleApp_as
{
    class Program
    {
        static void Main(string[] args)
        {
            Product dorayaki = new Product(98, "どらやき", 210);

            int id = dorayaki.Id;
            string name = dorayaki.Name;
            int price = dorayaki.Price;

            int totalPrice = price + dorayaki.GetTax();
            Console.WriteLine("{0}番、{1}は{2}円です", id, name, totalPrice);

        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(int id, string name, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public int GetTax()
        {
            return (int)(Price * 0.08);
        }

        public int TotalPrice()
        {
            return Price + GetTax();
        }
    }
}
