using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoPredictor.Models.Response
{
    public class PriceResponse : PriceResponse
    {
        public Guid RequestId { get; set; }

        public DateTime TimeStamp { get; set; }

        public string ReturnedCurrency { get; set; }
    }
}
