using System;

namespace CryptoPredictor.Core
{
    public interface IConverter<T>
    {
        T Convert(object objectToConvert);

        Type ConvertFromType { get; }

        Type ConvertToType { get; }
    }
}
