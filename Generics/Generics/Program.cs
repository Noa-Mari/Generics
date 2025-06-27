using Generics.CodeCs.DataFlow;



DataFlow<string> dataFlow = new DataFlow<string>();

dataFlow.AddBlock(new UpperCaseBlock());
dataFlow.AddBlock(new UpperCaseBReplaceAWithSixBlocklock());
dataFlow.AddBlock(new ReverseBlock());

string input = "abCd";
input = dataFlow.RunFlow(input);

System.Console.WriteLine(input);