using Generics.interfaces.IBlock;


namespace Generics.CodeCs.DataFlow
{
    public class UpperCaseBReplaceAWithSixBlocklock : IBlock<string>
    {
        public string Process(string input)
        {
            return input.Replace("A", "6");
        }
    }
}
