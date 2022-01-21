using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace CryptoPredictor.Core
{
    public class InternalErrorException : SystemException
    {
        public InternalErrorException(
            string exceptionMsg,
            Guid requestId): base(exceptionMsg)
        {
            this.RequestId = requestId;
        }

        public HttpStatusCode StatusCode => HttpStatusCode.InternalServerError;

        public Guid RequestId { get; }
    }
}
