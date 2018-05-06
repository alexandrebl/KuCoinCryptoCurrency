using System;
using System.Collections.Generic;
using System.Text;

namespace KuCoinCryptoCurrency.Domain.Entity
{
    public class TickerReport {
        public bool Success { get; set; } 
        
        public string Code { get; set; }
        public string Msg { get; set; }

        public long TimeStamp { get; set; }

        public ICollection<Ticker> Data { get; set; }
    }
}
