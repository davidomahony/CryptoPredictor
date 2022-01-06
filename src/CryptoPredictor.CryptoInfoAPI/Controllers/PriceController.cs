using CryptoPredictor.CryptoInfoAPI.Services;
using CryptoPredictor.Models.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoPredictor.CryptoInfoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class PriceController : ControllerBase
    {
        private ILogger<PriceController> logger;
        private PriceService priceService;

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
                // Once I have set up the middle ware for handling exceptions this will throw a different exception
                throw new Exception();
            }
        }
    }
}
