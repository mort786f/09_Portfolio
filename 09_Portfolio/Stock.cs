using System;

namespace _09_Portfolio
{
    internal class Stock
    {
        public Stock()
        {
            
        }

        public int NumShares { get; internal set; }
        public double PricePerShare { get; internal set; }
        public string Symbol { get; internal set; }

        internal int GetValue()
        {
            throw new NotImplementedException();
        }
    }
}