using System;
using System.Collections.Generic;

namespace CryptoPredictor.Models.Response
{
    public class PriceHistoricalDataResponse : PriceResponse
    {
        public IEnumerable<HistoricalData> Results { get; set; }
    }
}
