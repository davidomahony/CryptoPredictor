using System;
using System.Collections.Generic;

namespace CryptoPredictor.Models.Response
{
    public class PriceHistoricalDataResponse
    {
        public IEnumerable<HistoricalData> Results { get; set; }
    }
}
