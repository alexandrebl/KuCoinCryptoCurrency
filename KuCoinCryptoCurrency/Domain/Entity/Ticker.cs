namespace KuCoinCryptoCurrency.Domain {

    public class Ticker {
      public string CoinType { get; set; }
      public bool Trading { get; set; }
        public double LastDealPrice { get; set; }
        public double Buy { get; set; }
        public double Sell { get; set; }
        public string CoinTypePair { get; set; }
        public int Sort { get; set; }
        public double FeeRate { get; set; }
        public long VolValue { get; set; }
        public double High { get; set; }
        public long DateTime { get; set; }
        public long Vol { get; set; }
        public double Low { get; set; }
        public double ChangeRate { get; set; }
    }
}