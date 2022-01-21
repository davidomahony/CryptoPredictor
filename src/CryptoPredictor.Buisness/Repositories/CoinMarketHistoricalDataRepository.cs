using CryptoPredictor.Core;
using CryptoPredictor.Models.Requests;
using CryptoPredictor.Models.Response;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace CryptoPredictor.Buisness.Repositories
{
    public class CoinMarketHistoricalDataRepository : IDataRepository<CoinMarketHistoricalDataResponse, PriceHistoricalDataRequest>
    {
        private readonly HttpClient httpClient;

        public CoinMarketHistoricalDataRepository(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public CoinMarketHistoricalDataResponse GetData(PriceHistoricalDataRequest info)
        {
            var request = this.GenerateRequestMessage(info);

            try
            {
                var result = this.httpClient.Send(request);
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseContent = result.Content.ReadAsStringAsync().Result;
                    var deserializedResponse = JsonConvert.DeserializeObject<CoinMarketHistoricalDataResponse>(responseContent);

                    if (deserializedResponse == null)
                    {
                        // throw me
                    }

                    return deserializedResponse;
                }
            }
            catch (Exception ex)
            {
                // throw me
            }

            return null;
        }

        private HttpRequestMessage GenerateRequestMessage(PriceHistoricalDataRequest info)
        {
            var startTimeUnix = ((DateTimeOffset)info.StartDate).ToUnixTimeSeconds();
            var endTimeUnix = ((DateTimeOffset)info.EndDate).ToUnixTimeSeconds();

            var request = new HttpRequestMessage(HttpMethod.Get, new Uri($"https://api.coinmarketcap.com/data-api/v3/cryptocurrency/historical?id=1&convertId=2781&timeStart={startTimeUnix}&timeEnd={endTimeUnix}"));
            request.Headers.Add("authority", "api.coinmarketcap.com");
            request.Headers.Add("path", $"/data-api/v3/cryptocurrency/historical?id=1&convertId=2781&timeStart={startTimeUnix}&timeEnd={endTimeUnix}");
            request.Headers.Add("authority", "api.coinmarketcap.com");
            request.Headers.Add("Accept", "*/*");
            request.Headers.Add("User-Agent", "PostmanRuntime/7.28.4");
            request.Headers.Add("Connection", "keep-alive");

            return request;
        }
    }
}
