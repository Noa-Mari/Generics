using Generics.interfaces.IBlock;


namespace Generics.CodeCs.DataFlow
{
    public class UpperCaseBlock : IBlock<string> 
    {
        public string Process(string input)
        {
            return input.ToUpper();
        }
    } 
}