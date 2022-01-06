

namespace CryptoPredictor.Core
{
    public interface IDataRepository<T>
    {
        T GetData(object info);
    }
}
