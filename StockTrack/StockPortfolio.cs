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
        public void AddStock(float stock)
        {
            stocks.Add(stock);
        }
        private List<float> stocks;

        private List<float> stocks = new List<float>();
    }
}
