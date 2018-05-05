using System;
using System.Net.Http;

namespace KuCoinCryptoCurrency.Utility {

    public class HttpUtilityTool : IHttpUtilityTool {

        private static readonly HttpClient HttpClient
            = new HttpClient(new HttpClientHandler { MaxConnectionsPerServer = 2000 });

        public HttpResponseMessage GetData(Uri uri) {
            var httpRequestTask = HttpClient.GetAsync(uri);

            var httpResponseMessage = httpRequestTask.Result;

            return httpResponseMessage;
        }
    }
}