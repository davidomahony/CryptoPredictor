using CryptoPredictor.Core;
using CryptoPredictor.Models;
using CryptoPredictor.Models.Requests;
using CryptoPredictor.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoPredictor.CryptoInfoAPI.Services
{
    public class PriceService
    {
        private readonly IDataRepository<HistoricalData> repository;
        private readonly IReponseGenerator<PriceResponse> responseGenerator;

        public PriceService(IDataRepository<HistoricalData> repository, IReponseGenerator<PriceResponse> responseGenerator)
        {
            this.repository = repository;
            this.responseGenerator = responseGenerator;
        }

        public PriceResponse GenerateHistoricalDataResponse(PriceHistoricalDataRequest request)
        {
            return null;
        }
    }
}
