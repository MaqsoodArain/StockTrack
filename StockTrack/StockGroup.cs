using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StockTrack
{
    public class StockGroup
    {
        public StockGroup()
        {
            stocks = new List<float>();
        }
        public StockMetrics ComputeStatistics()
        {
            StockMetrics stats = new StockMetrics();

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

        public void ListStocks(TextWriter destination)
        {
            Console.WriteLine("The price of stocks in the list is as follows:");
            for (int i = 0; i < stocks.Count; i++ )
            {
                destination.WriteLine(stocks[i]);
                
            }
            Console.WriteLine();
            float sum = stocks.Sum();
            Console.WriteLine("The total value of the stock portfolio is {0}.", sum);
            Console.WriteLine();

        }
        public void AddStock(float stock)
        {
            stocks.Add(stock);
        }
        public List<float> stocks;

      
    }
}
