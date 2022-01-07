using System;
using CryptoPredictor.Core;
using CryptoPredictor.Models.Requests;
using CryptoPredictor.Models.Response;

namespace CryptoPredictor.Buisness.ResponseGenerators
{
    public class PriceResponseGenerator : IResponseGenerator<PriceResponse>
    {
        private IConverterFactory<IConverter<PriceResponse>> converterFactory;

        public PriceResponseGenerator(IConverterFactory<IConverter<PriceResponse>> converterFactory)
        {
            this.converterFactory = converterFactory;
        }

        public PriceResponse GeneratorResponse(BaseRequest baseRequest, object incomingData, Type dataType,  Type targetType)
        {
            var converter = this.converterFactory.GetConverter(dataType, targetType);

            var response = converter.Convert(incomingData);

            if (response == null)
            {
                // Throw 5XX error
            }

            response.RequestId = baseRequest.RequestId;
            response.TimeStamp = baseRequest.Timestamp;

            return response;
        }
    }
}
