// C#6  syntactic sugar :)
using System.Diagnostics.CodeAnalysis;

Console.WriteLine(Sum(1, 2));
int Sum(int a, int b) => a + b;
AddWrapper(1, 5);
//Local Functions (New 7.0, Updated 9.0) **does not support overloading
int AddWrapper(int a, int b)
{
    if (a < 1000 && b < 1000)
    {
        return Add();
        int Add()
        {
            return a = b;
        }
    }
    else
        return 0;
}
#nullable enable
void Process(string?[] lines, string mark)
{
    foreach (var line in lines)
    {
        if (IsValid(line))
        {
            //Processing logic...
        }
    }
    bool IsValid([NotNullWhen(true)] string? line)
    {
        return !string.IsNullOrEmpty(line) && line.Length >= mark.Length;
    }
}
int vi = 1, vy = 5;
Console.WriteLine("Before call: X: {0}, Y: {1}", vi, vy);
Console.WriteLine("Answer is: {0}", AddvalueType(vi, vy));
Console.WriteLine("After call: X: {0}, Y: {1}", vi, vy);
// Value type arguments are passed by value by default.
static int AddvalueType(int x, int y)
{
    int ans = x + y;
    // Caller will not see these changes
    // as you are modifying a copy of the
    // original data.
    x = 10000;
    y = 88888;
    return ans;
}

// Output parameters must be assigned by the called method.
void AddUsingOutParam(int x, int y, out int ans)
{
    ans = x + y;
}
//int ans = 0;
// No need to assign initial value to local variables
// used as output parameters, provided the first time
// you use them is as output arguments.
// C# 7 allows for out parameters to be declared in the method call
AddUsingOutParam(90, 90, out int ans);
Console.WriteLine("90 + 90 = {0}", ans);
// void ThisWontCompile(out int a)
// {
//  Console.WriteLine("Error! Forgot to assign output arg!");
// }


//Discarding out Parameters (New 7.0)
AddUsingOutParam(90, 90, out _);


// • Output parameters do not need to be initialized before they are passed to the method. 
//   The reason for this is that the method must assign output parameters before exiting.
// • Reference parameters must be initialized before they are passed to the method. 
//   The reason for this is that you are passing a reference to an existing variable. If you 
//   do not assign it to an initial value, that would be the equivalent of operating on an 
//   unassigned local variable

// Reference parameters.
void SwapStrings(ref string s1, ref string s2)
{
    string tempStr = s1;
    s1 = s2;
    s2 = tempStr;
}
string str1 = "Flip";
string str2 = "Flop";

Console.WriteLine("Before: {0}, {1} ", str1, str2);
SwapStrings(ref str1, ref str2);
Console.WriteLine("After: {0}, {1} ", str1, str2);

//Using the (in) Modifier (New 7.2)
int AddReadOnly(in int x, in int y)
{
    //readonly Reference Type
    //Error CS8331 Cannot assign to variable 'in int' because it is a readonly variable
    //x = 10000;
    //y = 88888;
    int ans = x + y;
    return ans;
}
int aa = 2, bb = 5;
Console.WriteLine(AddReadOnly(aa, bb));

//Using the params Modifier
// Return average of "some number" of doubles.
double CalculateAverage(params double[] values)
{
    Console.WriteLine("You sent me {0} doubles.", values.Length);
    double sum = 0;
    if (values.Length == 0)
    {
        return sum;
    }
    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }
    return (sum / values.Length);
}
double average;
average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
Console.WriteLine("Average of data is: {0}", average);
// ...or pass an array of doubles.
double[] data = { 4.0, 3.2, 5.7 };
average = CalculateAverage(data);
Console.WriteLine("Average of data is: {0}", average);
// Average of 0 is 0!
Console.WriteLine("Average of data is: {0}", CalculateAverage());

//Defining Optional Parameters
void EnterLogData(string message, string owner = "Programmer")
{
    // Console.Beep();
    Console.WriteLine("Error: {0}", message);
    Console.WriteLine("Owner of Error: {0}", owner);
}
EnterLogData("File Not Found");

// Error! The default value for an optional arg must be known
// at compile time!
// static void EnterLogData(string message, string owner = "Programmer", DateTime timeStamp = 
// DateTime.Now)
// {
//  Console.Beep();
//  Console.WriteLine("Error: {0}", message);
//  Console.WriteLine("Owner of Error: {0}", owner);
//  Console.WriteLine("Time of Error: {0}", timeStamp);
// }

//Using Named Arguments (Updated 7.2)
void DisplayFancyMessage(ConsoleColor textColor,
ConsoleColor backgroundColor, string message)
{
    // Store old colors to restore after message is printed.
    ConsoleColor oldTextColor = Console.ForegroundColor;
    ConsoleColor oldbackgroundColor = Console.BackgroundColor;
    // Set new colors and print message.
    Console.ForegroundColor = textColor;
    Console.BackgroundColor = backgroundColor;
    Console.WriteLine(message);
    // Restore previous colors.
    Console.ForegroundColor = oldTextColor;
    Console.BackgroundColor = oldbackgroundColor;
}
DisplayFancyMessage(message: "Wow! Very Fancy indeed!",
 textColor: ConsoleColor.DarkRed,
 backgroundColor: ConsoleColor.White);

// This is OK, as positional args are listed before named args.
DisplayFancyMessage(ConsoleColor.Blue,
 message: "Testing...",
 backgroundColor: ConsoleColor.White);
// This is OK, all arguments are in the correct order
DisplayFancyMessage(textColor: ConsoleColor.White, backgroundColor: ConsoleColor.Blue,
"Testing...");
// This is an ERROR, as positional args are listed after named args.
// DisplayFancyMessage(message: "Testing...",
//  backgroundColor: ConsoleColor.White,
//  ConsoleColor.Blue);

//A practical example 
void DisplayFancyMessagePractical(ConsoleColor textColor = ConsoleColor.Green,
ConsoleColor backgroundColor = ConsoleColor.DarkGray, string message = "Test Message")
{
    // Store old colors to restore after message is printed.
    ConsoleColor oldTextColor = Console.ForegroundColor;
    ConsoleColor oldbackgroundColor = Console.BackgroundColor;
    // Set new colors and print message.
    Console.ForegroundColor = textColor;
    Console.BackgroundColor = backgroundColor;
    Console.WriteLine(message);
    // Restore previous colors.
    Console.ForegroundColor = oldTextColor;
    Console.BackgroundColor = oldbackgroundColor;
}
DisplayFancyMessagePractical(message: "this is A practical example for Named Parameters");

ClassOverLoad c = new ClassOverLoad();
public class ClassOverLoad
{
    public ClassOverLoad()
    {
        int x = 2;
        OverLoadAdd(1, ref x);
        Console.WriteLine(x);
    }
    //Over Loading
    int OverLoadAdd(int x, int y)
    {
        return x + y;
    }
    long OverLoadAdd(int x, ref int y)
    {
        return x + y;
    }
    //error when more than one modifier is used (in ,out ,ref)
    // long OverLoadAdd(int x, out int y)
    // {
    //     return x + y;
    // }
    // long OverLoadAdd(int x, in int y)
    // {
    //     return x + y;
    // }
    long OverLoadAdd(long x, long y, long z)
    {
        return x + y + z;
    }
}


