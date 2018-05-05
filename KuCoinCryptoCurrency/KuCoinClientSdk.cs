using KuCoinCryptoCurrency.Domain;
using KuCoinCryptoCurrency.Processor;

namespace KuCoinCryptoCurrency {

    public sealed class KuCoinClientSdk {
        private readonly IKuCoinProcessor _kuCoinProcessor;

        public KuCoinClientSdk(IKuCoinProcessor kuCoinProcessor) {
            _kuCoinProcessor = kuCoinProcessor;
        }

        public Response GetTickerLast24Hs() {
            var response = _kuCoinProcessor.GetTickerLast24Hs();

            return response;
        }
    }
}