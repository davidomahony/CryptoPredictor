using CryptoPredictor.Core;
using CryptoPredictor.Models;
using CryptoPredictor.Models.Requests;
using CryptoPredictor.Models.Response;

namespace CryptoPredictor.CryptoInfoAPI.Services
{
    public class PriceService
    {
        private readonly IDataRepository<HistoricalData> repository;
        private readonly IResponseGenerator<PriceResponse> responseGenerator;

        public PriceService(IDataRepository<HistoricalData> repository, IResponseGenerator<PriceResponse> responseGenerator)
        {
            this.repository = repository;
            this.responseGenerator = responseGenerator;
        }

        public PriceResponse GenerateHistoricalDataResponse(PriceHistoricalDataRequest request)
        {
            var dataFromRepository = this.repository.GetData(request);

            var generatedResponse = this.responseGenerator.GeneratorResponse(
                dataFromRepository,
                dataFromRepository.GetType(),
                typeof(PriceHistoricalDataResponse));
            
            if (generatedResponse == null)
            {
                // Throw 5XX error
            }

            return generatedResponse;
        }
    }
}
