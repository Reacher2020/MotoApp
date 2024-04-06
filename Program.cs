using  MotoApp;

var stack = new BasicStack<double>();
var stackString = new BasicStack<string>();
stack.Push(item:4.5);
stack.Push(item:43);
stack.Push(item: 333.6);

stackString.Push(item: "Compamy1 ");
stackString.Push(item: "Compamy2 ");
stackString.Push(item: "Compamy3 ");

double sumD = 0.0;
while(stack.Count() > 0)
{
    double itemD = stack.Pop();
    Console.WriteLine($"Item: {itemD}");
    sumD += itemD;
}
Console.WriteLine($"Sum: {sumD}");

string sumS = "";
while (stackString.Count() > 0)
{
    string itemS = stackString.Pop();
    Console.WriteLine($"Item: {itemS}");
    sumS += itemS;
}
Console.WriteLine(sumS);