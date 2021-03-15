using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var sale = new Sale
            {
                ProductName = "もやし",
                UnitPrice = 150,
                Quantity = 80
            };
            Console.WriteLine($"商品名：{sale.ProductName} 価格：{sale.UnitPrice}円  量：{sale.Quantity}g");
        }

        class Sale
        {
            private string _productName;
            private int _unitPrice;
            private int _quantity;
            public string ProductName
            {
                get { return _productName; }
                set { _productName = value; }
            }
            public int UnitPrice
            {
                get { return _unitPrice; }
                set { _unitPrice = value; }
            }
            public int Quantity
            {
                get { return _quantity; }
                set { _quantity = value; }
            }
        }
    }

    
}
