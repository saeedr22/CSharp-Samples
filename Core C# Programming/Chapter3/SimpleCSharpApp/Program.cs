using System;
using System.Numerics;
using System.Text;

// Display a simple message to the user.
Console.WriteLine("***** My First C# App With top-level Statement*****");
Console.WriteLine("Hello World!");
Console.WriteLine();
//Console.BackgroundColor = ConsoleColor.DarkBlue;
// for (var i = 0; i < args.Length; i++)
// {
//     //  Console.Beep();
//     Console.WriteLine("arg :{0}", args[i]);
// }

// var argList = Environment.GetCommandLineArgs();
// foreach (var item in argList)
// {
//     Console.WriteLine($"argListItem:{item}");
// }

// foreach (string drive in Environment.GetLogicalDrives())
// {
//     Console.WriteLine("Drive: {0}", drive);
// }
// Console.WriteLine("OS: {0}", Environment.OSVersion);
// Console.WriteLine("Number of processors: {0}",
// Environment.ProcessorCount);
// Console.WriteLine(".NET Core Version: {0}",
// Environment.Version);
// Console.WriteLine("UserName: {0}",
// Environment.UserName);
// Console.WriteLine("MachineName: {0}",
// Environment.MachineName);
// Console.WriteLine("Is64BitOperatingSystem: {0}",
// Environment.Is64BitOperatingSystem);
// test();
// static void test()
// {
//     int i;
//     // Console.Write();
// }

// int dint = default;//c#7
// bool dbool = default;
// string dstring = "saeed";
// int nintshortcut = new();//c#9
// int nint = new int();//old c#
// DateTime dDateTime = default;//c#7
// DateTime nDateTime = new();//c#9
// Console.WriteLine($"default value of int {dint}");
// Console.WriteLine($"default value of by new int() {nint}");
// Console.WriteLine($"default value of by new  {nintshortcut}");
// Console.WriteLine($"default value of bool {dbool}");
// Console.WriteLine($"default value of default datetime {dDateTime}");
// Console.WriteLine($"default value of new() datetime  {nDateTime}");
// Console.WriteLine($"default value of string {dstring}is space");

// Console.WriteLine($"12 hashcode: {dstring.GetHashCode()}");
// Console.WriteLine($"int maxvalue: {int.MaxValue}");
// Console.WriteLine($"int minvalue: {int.MinValue}");

// Console.WriteLine("Max of double: {0}", double.MaxValue);
// Console.WriteLine("Min of double: {0}", double.MinValue);
// Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
// Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
// Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);

// float f = 2.5f;
// double d = 2.5d;
// long l = 400L;
// decimal de = 4222.5555M;
// ParseFromStrings();
// bool bb;
// bool.TryParse("saeed", out bb);
// Console.WriteLine("tryParse saeed:{0}", bb.ToString());

// UseDatesAndTimes();
// UseBigInteger();
// DigitSeparators();
// BinaryLiterals();
// SrtingMembers();
// EscapeChars();
// VerbatimStrings();
// StringEquality();
// StringEqualitySpecifyingCompareRules();
int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
var subset = from i in numbers where i < 10 select i;
Console.Write("Values in subset: ");
foreach (var i in subset)
{
Console.Write("{0} ", i);
}
Console.WriteLine();
// Hmm...what type is subset?
Console.WriteLine("subset is a: {0}", subset.GetType().Name);
Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);

StringsAreImmutable2();
FunWithStringBuilder();
return 0;

static void ParseFromStrings()
{
    Console.WriteLine("=> Data type parsing:");
    bool b = bool.Parse("True");
    Console.WriteLine("Value of b: {0}", b);
    double d = double.Parse("99.884");
    Console.WriteLine("Value of d: {0}", d);
    int i = int.Parse("8");
    Console.WriteLine("Value of i: {0}", i);
    char c = Char.Parse("w");
    Console.WriteLine("Value of c: {0}", c);
}

static void UseDatesAndTimes()
{
    Console.WriteLine("=> Dates and Times:");
    // This constructor takes (year, month, day).
    DateTime dt = new DateTime(2015, 10, 17);
    // What day of the month is this?
    Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
    // Month is now December.
    dt = dt.AddMonths(2);
    Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
    // This constructor takes (hours, minutes, seconds).
    TimeSpan ts = new TimeSpan(4, 30, 0);
    Console.WriteLine(ts);
    // Subtract 15 minutes from the current TimeSpan and
    // print the result.
    Console.WriteLine(ts.Subtract(new TimeSpan(0, -15, 0)));
    Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
}

static void UseBigInteger()
{
    Console.WriteLine("=> Use BigInteger:");
    BigInteger biggy =
    BigInteger.Parse("999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999");
    Console.WriteLine("Value of biggy is {0}", biggy);
    Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
    Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
    BigInteger reallyBig = BigInteger.Multiply(biggy,
    BigInteger.Parse("8888888888888888888888888888888888888888888"));
    Console.WriteLine("Value of reallyBig is {0}", reallyBig);
}

static void DigitSeparators()
{
    int io = 12_12;
    Console.WriteLine("=> Use Digit Separators:");
    Console.Write("Integer:");
    Console.WriteLine(123_456);
    Console.Write("Long:");
    Console.WriteLine(123_456_789L);
    Console.Write("Float:");
    Console.WriteLine(123_456.1234F);
    Console.Write("Double:");
    Console.WriteLine(123_456.12);
    Console.Write("Decimal:");
    Console.WriteLine(123_456.12M);
    //Updated in 7.2, Hex can begin with _
    Console.Write("Hex:");
    Console.WriteLine(0x_00_FF_FF);
    Console.WriteLine(io);
}


static void BinaryLiterals()
{
    //Updated in 7.2, Binary can begin with _
    Console.WriteLine("=> Use Binary Literals:");
    Console.WriteLine("Sixteen: {0}", 0b_0001_0000);
    Console.WriteLine("Thirty Two: {0}", 0b_0010_0000);
    Console.WriteLine("Sixty Four: {0}", 0b_0100_0000);
    Console.WriteLine(" b: {0}", 0b_1000_0000);
    Console.WriteLine(" b: {0}", 0b_0000_0010);
}

static void SrtingMembers()
{
    Console.WriteLine("'{0}'", "saeed".PadLeft(6));
    Console.WriteLine("'{0}'", "saeed".PadRight(6));

    int[] intArray = { 1, 3, 5, 7, 9 };
    String seperator = ", ";
    string result = "Int, ";
    result += String.Join(seperator, intArray);
    Console.WriteLine($"Result: {result}");
}

static void EscapeChars()
{
    Console.WriteLine("=> Escape characters:\a");
    string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
    Console.WriteLine(strWithTabs);
    Console.WriteLine("Everyone loves \"Hello World\"\a ");
    Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
    // Adds a total of 4 blank lines (then beep again!).
    Console.WriteLine("All finished.\n\n\n\a ");
    Console.WriteLine("saeed \r r");
}

//C# 8
static void VerbatimStrings()
{
    string name = "saeed";
    string Verbatim = @$"hi 
        my name
        is : 
            {name}";
    Console.WriteLine(Verbatim);
}

static void StringEquality()
{
    Console.WriteLine("=> String equality:");
    string s1 = "Hello!";
    string s2 = "Yo!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();
    // Test these strings for equality.
    Console.WriteLine("s1 == s2: {0}", s1 == s2);
    Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
    Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
    Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
    Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
    Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
    Console.WriteLine();
}

static void StringEqualitySpecifyingCompareRules()
{
    Console.WriteLine("=> String equality (Case Insensitive:");
    string s1 = "Hello!";
    string s2 = "HELLO!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();
    // Check the results of changing the default compare rules.
    Console.WriteLine("Default rules: s1={0},s2={1}s1.Equals(s2): {2}", s1, s2,
    s1.Equals(s2));
    Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}",
    s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
    Console.WriteLine();
    Console.WriteLine("Default rules: s1={0},s2={1} s1.IndexOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
    Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase):{0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}",
    s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
}

static void StringsAreImmutable2()
{
    Console.WriteLine("=> Immutable Strings 2:\a");
    string s2 = "My other string";
    s2 = "New string value";
}

static void FunWithStringBuilder()
{
    Console.WriteLine("=> Using the StringBuilder:");
    StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
 
    sb.AppendLine("Half Life");

    Console.WriteLine(sb.ToString());
}