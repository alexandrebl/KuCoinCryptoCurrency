using KuCoinCryptoCurrency.Domain;

namespace KuCoinCryptoCurrency.Processor {

    public interface IKuCoinProcessor {

        Response GetTickerLast24Hs();
    }
}