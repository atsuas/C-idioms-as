using System;

namespace ConsoleApp_as
{
    class Program
    {
        static void Main(string[] args)
        {
            Product karinto = new Product(123, "かりんとう", 180);
            Product daihuku = new Product(235, "大福もち", 360); //複数のインスタンスも生成できる

            int price = karinto.Price;
            int daihukuPrice = daihuku.Price;

            int karintoTax = karinto.GetTax(); //変数karintoを通じてオブジェクトにアクセスできる
            int daihukuTax = daihuku.GetTax();

            int daihukuTotal = daihukuPrice + daihukuTax;

            int taxIncluded = karinto.GetPriceIncludingTax();

            Console.WriteLine(karinto);
            Console.WriteLine(daihuku);
            Console.WriteLine(daihukuTotal);
            Console.WriteLine("かりんとうの税率は{0}円です", daihukuTotal);
            Console.WriteLine(taxIncluded);

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
