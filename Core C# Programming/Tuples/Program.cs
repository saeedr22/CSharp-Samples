(string, int, string, bool) s = ("saeed", 1, "rezaei", true);
Console.WriteLine(s.Item1 + " " + s.Item2 + " " + s.Item3 + " " + s.Item4);

//Sample2
(string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("a", 5, "c");
var valuesWithNames2 = (FirstLetter: "a", TheNumber: 5, SecondLetter: "c");

Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");
//Using the item notation still works!
Console.WriteLine($"First item: {valuesWithNames.Item1}");
Console.WriteLine($"Second item: {valuesWithNames.Item2}");
Console.WriteLine($"Third item: {valuesWithNames.Item3}");
//Nested Tuples
Console.WriteLine("=> Nested Tuples");
var nt = (5, 4, ("a", "b"));
Console.WriteLine(nt.Item3.Item1);

//Using Inferred Variable Names (Updated 7.1)
Console.WriteLine("=> Inferred Tuple Names");
var foo = new { Prop1 = "first", Prop2 = "second" };
var bar = (foo.Prop1, foo.Prop2);
Console.WriteLine($"{bar.Prop1};{bar.Prop2}");

//Understanding Tuple Equality/Inequality (New 7.3)
Console.WriteLine("=> Tuples Equality/Inequality");
// lifted conversions
var left = (a: 5, b: 10);
(int? a, int? b) nullableMembers = (5, 10);
Console.WriteLine(left == nullableMembers); // Also true
// converted type of left is (long, long)
(long a, long b) longTuple = (5, 10);
Console.WriteLine(left == longTuple); // Also true
// comparisons performed on (long, long) tuples
(long a, int b) longFirst = (5, 10);
(int a, long b) longSecond = (5, 10);
Console.WriteLine(longFirst == longSecond); // Also true

//Understanding Tuples as Method Return Values
void FillTheseValues(out int a, out int b, out string s)
{
    a = 1;
    b = 10;
    s = "this is a sample Text";
}

(int, int, string) FillTheseValuesTuple()
{
    return (1, 10, "this is a sample Text");
}


(string first, string middle, string last) SplitNames(string fullName)
{
    var _fullName = fullName.Split(" ");
    return (_fullName[0], _fullName[1], _fullName[2]);
}

var (frstName, lastName, _) = SplitNames("Saeed Rezaei Iran");
Console.WriteLine($"{frstName}:{lastName}");

//Switch expression with Tuples
string RockPaperScissors(string name, string family)
{
    return (name, family) switch
    {
        ("saeed", "rezaei") => "Developer",
        ("sina", "rezaei") => "Programmer",
        ("ali", "mohammadi") => "Programmer",
        ("sara", "minayi") => "Tester",
        (_, _) => "Default Job"
    };
}

Console.WriteLine(RockPaperScissors("saeed", "rezaei"));
