﻿using KuCoinCryptoCurrency.Domain;
using KuCoinCryptoCurrency.Domain.Entity;
using KuCoinCryptoCurrency.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;

namespace KuCoinCryptoCurrency.Processor {

    public class KuCoinProcessor : IKuCoinProcessor {
        private static IHttpUtilityTool _httpUtilityTool;
        private readonly Uri _uri = new Uri(@"https://api.kucoin.com/v1/open/tick");

        public KuCoinProcessor(IHttpUtilityTool httpUtilityTool, Uri uri = null) {
            if(uri != null) _uri = uri;
            _httpUtilityTool = httpUtilityTool;
        }

        public Response GetTickerLast24Hs() {
            var httpResponseMessage = Get(_uri);

            return ParseHttpContent(httpResponseMessage);
        }

        private static Response ParseHttpContent(HttpResponseMessage httpResponseMessage) {
            if (!httpResponseMessage.IsSuccessStatusCode)
                return new Response {
                    StatusCode = HttpStatusCode.InternalServerError,
                    Erros = new Collection<Error>
                    {
                        new Error
                        {
                            Message = "Internal Server Error"
                        }
                    }
                };

            var content = httpResponseMessage.Content.ReadAsStringAsync().Result;
            var tickerReport = JsonConvert.DeserializeObject<TickerReport>(content);

            var response = new Response { TickerReport = tickerReport, StatusCode = HttpStatusCode.OK };

            return response;
        }

        private static HttpResponseMessage Get(Uri uri) {
            var httpResponseMessage = _httpUtilityTool?.GetData(uri);

            return httpResponseMessage;
        }
    }
}