using System;

namespace _09_Portfolio
{
    public class Stock
    {
        private string v1;
        private double v2;
        private int v3;

        public Stock()
        {
            
        }

        public Stock(string Symbol, double PricePerShare, double NumShares)
        {
            this.Symbol = Symbol;
            this.PricePerShare = PricePerShare;
            this.NumShares = NumShares;
        }

        public double NumShares { get; internal set; }
        public double PricePerShare { get; internal set; }
        public string Symbol { get; internal set; }

        public double GetValue()
        {
            return NumShares * PricePerShare;
        }

        public static double TotalValue(Stock[] stocks)
        {
            double x = stocks[0].NumShares * stocks[0].PricePerShare;
            double y = stocks[1].NumShares * stocks[1].PricePerShare;
            return x + y;
        }
        public override string ToString()
        {
            return "Stock[symbol=" + Symbol + ",pricePerShare=" + PricePerShare + ",numShares=" + NumShares + "]";
        }
        public override bool Equals(object obj)
        {
            Stock abc = (Stock)obj;
            return (this.Symbol == abc.Symbol && this.NumShares == abc.NumShares && this.PricePerShare == abc.PricePerShare);
        }
    }
}