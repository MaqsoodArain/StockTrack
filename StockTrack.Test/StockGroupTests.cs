using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrack.Test
{
    [TestClass]
    public class StockGroupTests
    {
        [TestMethod]
        public void CalculateLowestPrice()
        {
            StockGroup portfolio = new StockGroup();

            portfolio.AddStock(100);
            portfolio.AddStock(25);

            StockMetrics result = portfolio.ComputeStatistics();

            Assert.AreEqual(25, result.LowestStock);


        }

        [TestMethod]
        public void CalculateHighestPrice()
        {
            StockGroup portfolio = new StockGroup();

            portfolio.AddStock(100);
            portfolio.AddStock(25);

            StockMetrics result = portfolio.ComputeStatistics();

            Assert.AreEqual(100, result.HighestStock);


        }

        [TestMethod]
        public void CalculateAveragePrice()
        {
            StockGroup portfolio = new StockGroup();

            portfolio.AddStock(100);
            portfolio.AddStock(200);

            StockMetrics result = portfolio.ComputeStatistics();

            Assert.AreEqual(150, result.AverageStock);


        }

    }
}
