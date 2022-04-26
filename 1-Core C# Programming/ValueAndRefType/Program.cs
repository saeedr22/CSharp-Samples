// Assigning two intrinsic value types results in
// two independent variables on the st
ValueTypeAssignment();
RefTypeAssignment();
ValueTypeContainingRefType();
PassingRefTypesByBalue();
void ValueTypeAssignment()
{
    Console.WriteLine("Assigning value types");
    Point p1 = new Point(10);
    Point p2 = p1;
    // Print both points.
    p1.Display();
    p2.Display();
    // Change p1.X and print again. p2.X is not changed.
    p1.X = 100;
    Console.WriteLine("\n=> Changed p1.X");
    p1.Display();
    p2.Display();
}

void RefTypeAssignment()
{
    Console.WriteLine("Assigning Reference types");
    PointRef p1 = new PointRef(10);
    PointRef p2 = p1;
    // Print both points.
    p1.Display();
    p2.Display();
    // Change p1.X and print again. p2.X is changed.
    p1.X = 100;
    Console.WriteLine("\n=> Changed Reference p1.X");
    p1.Display();
    p2.Display();
}

void ValueTypeContainingRefType()
{
    // Create the first Rectangle.
    Console.WriteLine("-> Creating r1");
    Rectangle r1 = new Rectangle(10, 10, 50, 50, "First Rect");
    // Now assign a new Rectangle to r1.
    Console.WriteLine("-> Assigning r2 to r1");
    Rectangle r2 = r1;
    // Change some values of r2.
    Console.WriteLine("-> Changing values of r2");
    r2.RectInfo.InfoString = "This is new info!";
    //not changed in r1
    r2.Bottom = 4444;
    // Print values of both rectangles.
    r1.Display();
    r2.Display();
}

void PassingRefTypesByBalue()
{
    // Passing ref-types by value.
    Console.WriteLine("***** Passing Person object by value *****");
    Person fred = new Person("Fred", 12);
    Console.WriteLine("\nBefore by value call, Person is:");
    fred.Display();
    //SendAPersonByValue(fred);
    SendAPersonByReference(ref fred);
    Console.WriteLine("\nAfter by value call, Person is:");
    fred.Display();
    Console.ReadLine();
}

void SendAPersonByValue(Person p)
{
    p.personAge = 99;
    p = new Person("Saeed", 100);
    p.personAge = 101;
}

void SendAPersonByReference(ref Person p)
{
    // Change some data of "p".
    p.personAge = 555;
    // "p" is now pointing to a new object on the heap!
    p = new Person("Nikki", 999);
}

struct Point
{
    public Point(int x)
    {
        X = x;
    }
    public int X { get; set; }
    public void Display()
    {
        Console.WriteLine($"X Value is :{X}");
    }
}

// Classes are always reference types.
class PointRef
{
    // Same members as the Point structure...
    // Be sure to change your constructor name to PointRef!
    public int X { get; set; }
    public PointRef(int xPos)
    {
        X = xPos;
    }
    public void Display()
    {
        Console.WriteLine($"X Value is :{X}");
    }
}

//Using Value Types Containing Reference Types
class ShapeInfo
{
    public string InfoString;
    public ShapeInfo(string info)
    {
        InfoString = info;
    }
}

// Rectangle is a Struct
struct Rectangle
{
    public ShapeInfo RectInfo;
    public int Top, Left, Bottom, Right;
    public Rectangle(int top, int left, int bottom, int right, string info)
    {
        Top = top;
        Left = left;
        Bottom = bottom;
        Right = right;
        RectInfo = new ShapeInfo(info);
    }
    public void Display()
    {
        Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
        "Left = {3}, Right = {4}",
        RectInfo.InfoString, Top, Bottom, Left, Right);
    }
}

//Passing Reference Types by Value
public class Person
{
    public string personName;
    public int personAge;
    public Person(string name, int age)
    {
        personName = name;
        personAge = age;
    }
    public void Display()
    {
        Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
    }
}
//***
// • If a reference type is passed by reference, the callee may change the values of the 
// object’s state data, as well as the object it is referencing.
// • If a reference type is passed by value, the callee may change the values of the object’s 
// state data but not the object it is referencing