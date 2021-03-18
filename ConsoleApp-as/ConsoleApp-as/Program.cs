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
            var sale = new Sale
            {
                UnitPrice = 300,
                Quantity = 2,
                ProductName = "たこやき"
            };
            Console.WriteLine($"{sale.ProductName} {sale.UnitPrice}円 {sale.Quantity}個");
        }
       
    }

    class Sale
    {
        private int _unitPrice;
        private int _quantity;
        private string _productName;

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

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }


    }

}
