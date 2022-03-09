using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrack
{
    internal class StockPortfolio
    {
        public StockPortfolio()
        {
            stocks = new List<float>();
        }
        public StockStatistics ComputeStatistics()
        {
            StockStatistics stats = new StockStatistics();

            float sum = 0;
            foreach (float stock in stocks)
            {
                stats.HighestStock = Math.Max(stock, stats.HighestStock);
                stats.LowestStock = Math.Min(stock, stats.LowestStock);
                sum += stock;
            }
            stats.AverageStock = sum / stocks.Count;
            return stats;
        }
        public void AddStock(float stock)
        {
            stocks.Add(stock);
        }
        private List<float> stocks;

        //private List<float> stocks = new List<float>();
    }
}
