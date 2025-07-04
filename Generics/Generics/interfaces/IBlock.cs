
namespace Generics.interfaces.IBlock
{
    public interface IBlock<T> where T : class
    {
        T Process(T input);
    }
}
