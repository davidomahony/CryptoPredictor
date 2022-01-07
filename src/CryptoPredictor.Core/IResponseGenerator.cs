

using CryptoPredictor.Models.Requests;
using System;

namespace CryptoPredictor.Core
{
    public interface IResponseGenerator<T>
    {
        T GeneratorResponse(BaseRequest baseRequest, object incomingData, Type dataType, Type targetType);
    }
}
