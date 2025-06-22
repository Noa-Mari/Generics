using System;
using Generics.interfaces.IBlock;
using Generics.interfaces.IDataFlow;


namespace Generics.CodeCs.DataFlow
{
    public class ReverseBlock: IBlock<string> 
    {
        public string Process(string input)
        {
            char[] charArray = input.ToCharArray();

            string reversedString = String.Empty;

            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversedString += charArray[i];
            }

            return reversedString;
    
        }
    } 
}