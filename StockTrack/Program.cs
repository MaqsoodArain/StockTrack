using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockPortfolio portfolio = new StockPortfolio();

            portfolio.AddStock(15);
            portfolio.AddStock(20);
            portfolio.AddStock(90);
            portfolio.AddStock(250);
            portfolio.AddStock(5);
            portfolio.AddStock(120);
            portfolio.AddStock(120);
            portfolio.AddStock(200);

            StockStatistics stats = portfolio.ComputeStatistics();

            Console.WriteLine("The highest stock price is " + stats.HighestStock);
            Console.WriteLine("The average stock price is " + stats.AverageStock);
            Console.WriteLine("The lowest stock price is " + stats.LowestStock);

        

           
        }
    }
}
