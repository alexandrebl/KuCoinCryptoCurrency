using System;
using System.Linq;
using KuCoinCryptoCurrency.Processor;
using KuCoinCryptoCurrency.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KuCoinCryptoCurrency.Tests {
    [TestClass]
    public class ProcessorTests {
        [TestMethod]
        public void GetTickersLast24HsRequestSuccess() {
            IHttpUtilityTool httpUtilityTool = new HttpUtilityTool();
            IKuCoinProcessor kucoinProcessor = new KuCoinProcessor(httpUtilityTool);

            var tickerResponse = kucoinProcessor.GetTickerLast24Hs();

            Assert.IsNotNull(tickerResponse);
            Assert.IsTrue(tickerResponse.Success);
            Assert.IsTrue(tickerResponse.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsNotNull(tickerResponse.TickerReport);
            Assert.IsNotNull(tickerResponse.TickerReport.Data);
            Assert.IsTrue(tickerResponse.TickerReport.Data.Any());            
        }
    }
}
