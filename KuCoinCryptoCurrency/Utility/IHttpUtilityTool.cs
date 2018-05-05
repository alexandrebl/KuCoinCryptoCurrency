using System;
using System.Net.Http;

namespace KuCoinCryptoCurrency.Utility {

    public interface IHttpUtilityTool {

        HttpResponseMessage GetData(Uri uri);
    }
}