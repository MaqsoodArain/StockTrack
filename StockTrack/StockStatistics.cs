using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrack
{
    public class StockStatistics
    {
        public StockStatistics()
        {
            HighestStock = 0;
            LowestStock = float.MaxValue;
        }
        public float HighestStock;
        public float AverageStock;
        public float LowestStock;
    }
}
