// Make a Point by setting each property manually.
var firstPoint = new Point();
firstPoint.X = 10;
firstPoint.Y = 10;
firstPoint.Display();

// Or make a Point via a custom constructor.
Point anotherPoint = new Point(20, 20);
anotherPoint.Display();

// Or make a Point using object init syntax.
Point finalPoint = new Point { X = 30, Y = 30 };
finalPoint.Display();

// Calling a custom constructor.
//return x:100, y:100;
Point pt = new Point(10, 16) { X = 100, Y = 100 };
pt.Display();
//init only test
//Make readonly point after construction
PointReadOnlyAfterCreation firstReadonlyPoint = new PointReadOnlyAfterCreation(20, 20);
firstReadonlyPoint.DisplayStats();
// Or make a Point using object init syntax.
PointReadOnlyAfterCreation secondReadonlyPoint = new PointReadOnlyAfterCreation
{
    X = 30,
    Y = 30
};
secondReadonlyPoint.DisplayStats();
//The next two lines will not compile
// secondReadonlyPoint.X = 10;
// secondReadonlyPoint.Y = 10;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point() { }
    public Point(int xVal, int yVal)
    {
        X = xVal;
        Y = yVal;
    }

    public void Display()
    {
        Console.WriteLine($"x:{X}, y:{Y}");
    }
}

//Using init-Only Setters (New 9.0)
class PointReadOnlyAfterCreation
{
    public int X { get; init; }
    public int Y { get; init; }
    public void DisplayStats()
    {
        Console.WriteLine("InitOnlySetter: [{0}, {1}]", X, Y);
    }
    public PointReadOnlyAfterCreation(int xVal, int yVal)
    {
        X = xVal;
        Y = yVal;
    }
    public PointReadOnlyAfterCreation() { }
    
}