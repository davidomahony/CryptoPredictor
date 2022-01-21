using CryptoPredictor.Core.Exception;
using CryptoPredictor.CryptoInfoAPI.Services;
using CryptoPredictor.Models.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;

namespace CryptoPredictor.CryptoInfoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class PriceController : ControllerBase
    {
        private readonly ILogger<PriceController> logger;
        private readonly PriceService priceService;

        public PriceController(ILogger<PriceController> logger, PriceService priceService)
        {
            this.logger = logger;
            this.priceService = priceService;
        }


        [HttpGet]
        public IActionResult HistoricalData([Required] PriceHistoricalDataRequest incomingRequest)
        {
            ValidateHistoricalDataRequest(incomingRequest);

            var response = this.priceService.GenerateHistoricalDataResponse(incomingRequest);

            return Ok(response);
        }

        private static void ValidateHistoricalDataRequest(PriceHistoricalDataRequest requestToValidate)
        {
            if (requestToValidate.StartDate.CompareTo(requestToValidate.EndDate) > 0)
            {
                throw new ClientErrorException("Invalid Date", requestToValidate.RequestId);
            }
        }
    }
}
