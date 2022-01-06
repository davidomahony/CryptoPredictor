using System;
using System.ComponentModel.DataAnnotations;

namespace CryptoPredictor.Models.Requests
{
    public class PriceHistoricalDataRequest
    {
        [Required]
        public string CurrencyName { get; set; }

        public string ReturnedCurrency { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
    }
}
