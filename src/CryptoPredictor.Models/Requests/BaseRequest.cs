using System;

namespace CryptoPredictor.Models.Requests
{
    public class BaseRequest
    {
        public Guid RequestId { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
