using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrack.Test
{
    [TestClass]
    public class StockPortfolioTests
    {
        [TestMethod]
        public void CalculateLowestPrice()
        {
            StockPortfolio portfolio = new StockPortfolio();

            portfolio.AddStock(100);
            portfolio.AddStock(25);

            StockStatistics result = portfolio.ComputeStatistics();

            Assert.AreEqual(25, result.LowestStock);


        }

        [TestMethod]
        public void CalculateHighestPrice()
        {
            StockPortfolio portfolio = new StockPortfolio();

            portfolio.AddStock(100);
            portfolio.AddStock(25);

            StockStatistics result = portfolio.ComputeStatistics();

            Assert.AreEqual(100, result.HighestStock);


        }

        [TestMethod]
        public void CalculateAveragePrice()
        {
            StockPortfolio portfolio = new StockPortfolio();

            portfolio.AddStock(100);
            portfolio.AddStock(200);

            StockStatistics result = portfolio.ComputeStatistics();

            Assert.AreEqual(150, result.AverageStock);


        }

    }
}
