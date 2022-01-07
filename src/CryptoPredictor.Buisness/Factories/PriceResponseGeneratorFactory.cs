using System;
using System.Collections.Generic;
using System.Linq;
using CryptoPredictor.Core;
using CryptoPredictor.Models.Response;

namespace CryptoPredictor.Buisness.Factories
{
    public class PriceResponseConverterFactory : IConverterFactory<IConverter<PriceResponse>>
    {
        public IEnumerable<IConverter<PriceResponse>> availableConverters;

        public PriceResponseConverterFactory(IEnumerable<IConverter<PriceResponse>> availableConverters)
        {
            this.availableConverters = availableConverters;
        }

        public IConverter<PriceResponse> GetConverter(Type objectTypeToConvertFrom, Type objectTypeToConvertTo)
        {

            var converter = availableConverters.First(
                conv => conv.ConvertFromType.Equals(objectTypeToConvertFrom) && conv.ConvertToType.Equals(objectTypeToConvertTo));

            if (converter == null)
            {
                // throw a 5XX here
                throw new NotImplementedException();
            }

            return converter;
        }
    }
}
