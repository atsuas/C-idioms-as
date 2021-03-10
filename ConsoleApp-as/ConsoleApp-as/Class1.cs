using System;
using System.Collections.Generic;
using System.Text;

namespace DistanceConverter
{
    class FeetConverter
    {
        public double FromMeter(double meter)
        {
            return meter / 0.3048;
        }

        public double ToMeter(double feet)
        {
            return feet * 0.3048;
        }
    }
}
