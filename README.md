# KuCoinCryptoCurrency
KuCoin Crypto Currency .Net Client SDK

<strong>Develop branch</strong><br />
<img src="https://ci.appveyor.com/api/projects/status/github/alexandrebl/KuCoinCryptoCurrency?branch=develop&svg=true" alt="Project Badge" with="300">

<strong>Master branch</strong><br />
<img src="https://ci.appveyor.com/api/projects/status/github/alexandrebl/KuCoinCryptoCurrency?branch=master&svg=true" alt="Project Badge" with="300">

### Nuget Repository
https://www.nuget.org/packages/KuCoinCryptoCurrency/

### Install Package
Install-Package KuCoinCryptoCurrency

### How to use

```cs
using System;
using KuCoinCryptoCurrency.Processor;
using KuCoinCryptoCurrency.Utility;

namespace KuCoinLoadCurrencies {
    class Program {
        static void Main() {
            IHttpUtilityTool httpUtilityTool = new HttpUtilityTool();
            IKuCoinProcessor kucoinProcessor = new KuCoinProcessor(httpUtilityTool);

            var tickerResponse = kucoinProcessor.GetTickerLast24Hs();

            foreach (var ticker in tickerResponse.TickerReport.Data) {
                Console.WriteLine($"Crypt Coin: {ticker.CoinType} / Buy: {ticker.Buy} / Change Rate: {ticker.ChangeRate}");
            }

            Console.WriteLine("Processed");

            Console.ReadLine();
        }
    }
}
```
