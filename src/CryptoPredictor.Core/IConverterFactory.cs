using System;

namespace CryptoPredictor.Core
{
    public interface IConverterFactory<T>
    {
        T GetConverter(Type objectTypeToConvertFrom, Type objectTypeToConvertTo);
    }
}
