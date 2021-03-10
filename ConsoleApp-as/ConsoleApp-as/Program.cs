using System;
using System.Collections.Generic;
using System.IO;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        //売上データを読み込み、Saleオブジェクトのリストを返す
        static List<Sale> ReadSales(string filePath)
        {
            List<Sale> sales = new List<Sale>();    //売上データを入れるリストオブジェクトを生成
            string[] lines = File.ReadAllLines(filePath);   //ファイルから一気に読み込む
            foreach (string line in lines)  //読み込んだ行の数だけ繰り返す
            {
                string[] items = line.Split(',');
                Sale sale = new Sale    //Saleオブジェクトを生成
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale); //Saleオブジェクトをリストに追加
            }
            return sales;
        }
    }

    //売上クラス
    public class Sale
    {
        //店舗名
        public string ShopName { get; set; }
        //商品カテゴリ
        public string ProductCategory { get; set; }
        //売上高
        public int Amount { get; set; }

    }
}
