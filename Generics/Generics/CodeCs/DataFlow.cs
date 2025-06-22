using System;
using interfaces.IBlock;
using interfaces.IDataFlow;


namespace Generics.CodeCs.DataFlow
{
    public class DataFlow<T> : IDataFlow<T> where T : class, IBlock<T>
    {
        private List<IBlock<T>> _blockList;

        public DataFlow()
        {
            _blockList = new List<IBlock<T>>();
        }

        public void AddBlock(IBlock<T> block)
        {
            _blockList.Add(block);
        }

        public T RunFlow(T input)
        {
            int count = 0;
            foreach (IBlock<T> block in _blockList)
            {
                Console.WriteLine($"Processing block {count++}/{_blockList.Count}");
                input = block.Process(input);
            }

            return input;
        }
    }


}
