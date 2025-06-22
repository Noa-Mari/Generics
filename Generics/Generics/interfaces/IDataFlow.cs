using Generics.interfaces.IBlock;
namespace Generics.interfaces.IDataFlow
{
    public interface IDataFlow<T> where T : class
    {
        T RunFlow(T input);
        void AddBlock(IBlock<T> block);

    }
}
