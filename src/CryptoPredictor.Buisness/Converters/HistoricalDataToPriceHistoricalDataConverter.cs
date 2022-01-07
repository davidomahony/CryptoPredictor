using CryptoPredictor.Core;
using CryptoPredictor.Models;
using CryptoPredictor.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoPredictor.Buisness.Converters
{
    class HIstoricalDataToPriceHistoricalDataConverter : IConverter<PriceHistoricalDataResponse>
    {
        public Type ConvertFromType => typeof(HistoricalData);

        public Type ConvertToType => typeof(PriceHistoricalDataResponse);

        public PriceHistoricalDataResponse Convert(object objectToConvert)
        {
            throw new NotImplementedException();
        }
    }
}
