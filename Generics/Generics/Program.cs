using System;
using Generics.CodeCs.DataFlow;


// Assuming DataFlow<T> expects T : IBlock<string>
// Use DataFlow<IBlock<string>> and adjust usage accordingly
DataFlow<string> dataFlow = new DataFlow<string>();


dataFlow.AddBlock(new UpperCaseBlock());
dataFlow.AddBlock(new ReverseBlock());
dataFlow.AddBlock(new UpperCaseBReplaceAWithSixBlock());



string input = "Hello World! A";
string result = dataFlow.RunFlow(input);

Console.WriteLine($"Input: {input}");
Console.WriteLine($"Result: {result}");

// Output:
// Input: Hello World! A
// Result: !DLROW OLLEH 6

