Console.WriteLine("***** Fun with Generic Structures *****\n");
// Point using ints.
Point<int> p = new Point<int>(10, 10);
Console.WriteLine("p.ToString()={0}", p.ToString());
p.ResetPoint();
Console.WriteLine("p.ToString()={0}", p.ToString());
Console.WriteLine();
// Point using double.
Point<double> p2 = new Point<double>(5.4, 3.3);
Console.WriteLine("p2.ToString()={0}", p2.ToString());
p2.ResetPoint();
Console.WriteLine("p2.ToString()={0}", p2.ToString());
Console.WriteLine();
// Point using strings.
Point<string> p3 = new Point<string>("i", "3i");
Console.WriteLine("p3.ToString()={0}", p3.ToString());
p3.ResetPoint();
Console.WriteLine("p3.ToString()={0}", p3.ToString());

Point<string> p4 = default;
Point<int> p5 = default;
PatternMatching(p4);
PatternMatching(p5);
//Pattern Matching with Generics (New 7.1)
static void PatternMatching<T>(Point<T> p)
{
    switch (p)
    {
        case Point<string> pString:
            Console.WriteLine("Point is based on strings");
            return;
        case Point<int> pInt:
            Console.WriteLine("Point is based on ints");
            return;
    }
}
struct Point<T>
{
    private T _xPos;
    private T _yPos;
    // Generic constructor.
    public Point(T xVal, T yVal)
    {
        _xPos = xVal;
        _yPos = yVal;
    }

    // Generic properties.
    public T X
    {
        get => _xPos;
        set => _xPos = value;
    }
    public T Y
    {
        get => _yPos;
        set => _yPos = value;
    }
    public override string ToString() => $"[{_xPos}, {_yPos}]";

    // Reset fields to the default value of the type parameter.
    // The "default" keyword is overloaded in C#.
    // When used with generics, it represents the default
    // value of a type parameter.
    public void ResetPoint()
    {
        _xPos = default(T);
        _yPos = default(T);
    }

    // Default Literal Expressions (New 7.1)
    public void ResetPointLiteral()
    {
        _xPos = default;
        _yPos = default;
    }
}

