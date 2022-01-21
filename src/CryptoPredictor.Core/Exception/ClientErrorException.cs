using System;
using System.Net;

namespace CryptoPredictor.Core.Exception
{
    public class ClientErrorException : SystemException
    {
        public ClientErrorException(
            string exceptionMsg,
            Guid requestId) : base(exceptionMsg)
        {
            this.RequestId = requestId;
        }

        public HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

        public Guid RequestId { get; }
    }
}
