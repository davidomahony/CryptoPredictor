using CryptoPredictor.Core;
using CryptoPredictor.Models;
using CryptoPredictor.Models.Requests;
using CryptoPredictor.Models.Response;

namespace CryptoPredictor.CryptoInfoAPI.Services
{
    public class PriceService
    {
        private readonly IDataRepository<HistoricalData, PriceHistoricalDataRequest> repository;
        private readonly IResponseGenerator<PriceResponse> responseGenerator;

        public PriceService(IDataRepository<HistoricalData, PriceHistoricalDataRequest> repository, IResponseGenerator<PriceResponse> responseGenerator)
        {
            this.repository = repository;
            this.responseGenerator = responseGenerator;
        }

        public PriceResponse GenerateHistoricalDataResponse(PriceHistoricalDataRequest request)
        {
            var dataFromRepository = this.repository.GetData(request);

            var generatedResponse = this.responseGenerator.GeneratorResponse(
                request,
                dataFromRepository,
                dataFromRepository.GetType(),
                typeof(PriceHistoricalDataResponse));

            return generatedResponse;
        }
    }
}
