using System;
using Delegate_Sample1;
SimpleMath obj = new SimpleMath();
var b = new BinaryOp(obj.Add);
Console.WriteLine($" 10 + 10 is {b(10, 10)}");
DisplayDelegateInfo(b);
void DisplayDelegateInfo(Delegate delObj)
{
    foreach (var item in delObj.GetInvocationList())
    {
        Console.WriteLine($"method name is {item.Method}");
        Console.WriteLine($"type name is {item.Target}");
    }
}
class SimpleMath
{
    public int Add(int x, int y) => x + y;
    public int Subtract(int x, int y) => x - y;
}
namespace Delegate_Sample1
{
    public delegate int BinaryOp(int x, int y);
}
