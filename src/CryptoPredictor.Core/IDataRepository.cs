

namespace CryptoPredictor.Core
{
    public interface IDataRepository<out TResult, in TRequest>
    {
        TResult GetData(TRequest info);
    }
}
