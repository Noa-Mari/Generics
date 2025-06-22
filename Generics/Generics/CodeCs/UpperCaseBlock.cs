using System;
using Generics.interfaces.IBlock;
using Generics.interfaces.IDataFlow;


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