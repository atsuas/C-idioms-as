using System;
using System.Collections.Generic;
using System.Text;

namespace DistanceConverter
{
    public static class FeetConverter
    {
        private const double ratio = 0.3048; //定数ratioを定義
                                             //ratioを公開する場合はconstの代わりにstatic readonlyを使用する
        
        //メートルからフィートを求める
        public static double FromMeter(double meter)
        {
            return meter / 0.3048;
        }
        //フィートからメートルを求める
        public static double ToMeter(double feet)
        {
            return feet * 0.3048;
        }
    }
}
