using Generics.interfaces.IBlock;


namespace Generics.CodeCs.DataFlow
{
    public class ReverseBlock: IBlock<string> 
    {
        public string Process(string input)
        {

            return new string(input.Reverse().ToArray());
    
        }
    } 
}