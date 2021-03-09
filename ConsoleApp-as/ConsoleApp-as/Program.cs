using System;

namespace ConsoleApp_as
{
    class Program
    {
        static void Main(string[] args)
        {
            Product karinto = new Product(123, "かりんとう", 180);

            int price = karinto.Price;

            int taxIncluded = karinto.GetPriceIncludingTax();


        }
    }

    public class Product
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }

        //コンストラクタ
        public Product (int code, string name, int price)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }

        public int GetTax()
        {
            return (int)(Price * 0.08);
        }

        public int GetPriceIncludingTax()
        {
            return Price + GetTax();
        }
    }
}
