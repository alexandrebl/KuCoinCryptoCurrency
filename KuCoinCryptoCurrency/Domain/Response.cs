using KuCoinCryptoCurrency.Domain.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace KuCoinCryptoCurrency.Domain {

    public sealed class Response {
        public IEnumerable<Ticker> Tickers { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public bool Success => (Erros == null || !Erros.Any());
        public IEnumerable<Error> Erros { get; set; }
    }
}