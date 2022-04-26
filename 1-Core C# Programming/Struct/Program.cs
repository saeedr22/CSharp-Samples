//Struct var
Point p;
p.X = 1;
p.Y = 2;
p.Display();

ReadOnlyStruct rs = new ReadOnlyStruct(3, 4);
rs.Display();

PointWithReadOnly p3 =
 new PointWithReadOnly(50, 60, "Point w/RO");
p3.Display();

var s = new DisposableRefStruct(50, 60);
s.Display();
s.Dispose();

struct Point
{
    // Fields of the structure.
    public int X;
    public int Y;
    // A custom constructor.
    public Point(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }

    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
}

//.net 7.2
//ReadOnly Struct
readonly struct ReadOnlyStruct
{
    public int X { get; }
    public int Y { get; }
    public ReadOnlyStruct(int x, int y)
    {
        X = x;
        Y = y;
    }
    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
}

//Using Read-Only Members (New 8.0)
struct PointWithReadOnly
{
    // Fields of the structure.
    public int X;
    public readonly int Y;
    public readonly string Name;
    // Display the current position and name.
    public readonly void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}");
    }
    // A custom constructor.
    public PointWithReadOnly(int xPos, int yPos, string name)
    {
        X = xPos;
        Y = yPos;
        Name = name;
    }
}

//Using ref Structs (New 7.2)
// Also added in C# 7.2, the ref modifier can be used when defining a struct. This requires all instances of the 
// struct to be stack allocated and cannot be assigned as a property of another class. The technical reason for 
// this is that ref structs cannot referenced from the heap. The difference between the stack and the heap is 
// covered in the next section.
// These are some additional limitations of ref structs:
// • They cannot be assigned to a variable of type object or dynamic, and cannot be an 
//   interface type.
// • They cannot implement interfaces.
// • They cannot be used as a property of a non-ref struct.
// • They cannot be used in async methods, iterators, lambda expressions, or local functions.

//Using Disposable ref Structs (New 8.0)
ref struct DisposableRefStruct
{
    public int X;
    public readonly int Y;
    public readonly void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
    // A custom constructor.
    public DisposableRefStruct(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
        Console.WriteLine("Created!");
    }
    public void Dispose()
    {
        //clean up any resources here
        Console.WriteLine("Disposed!");
    }

}