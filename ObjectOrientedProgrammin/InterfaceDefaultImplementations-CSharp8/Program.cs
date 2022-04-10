Square sq = new Square("test") { NumberOfSides = 4, SideLength = 4 };
sq.Draw();
Console.WriteLine($"{sq.ShapeName} has {sq.NumberOfSides} of length {sq.SideLength} and a perimeter of {((IRegularPointy)sq).Perimeter}");
public interface IPointy
{
    byte Points { get; }
}

interface IRegularPointy : IPointy
{
    int SideLength { get; set; }
    int NumberOfSides { get; set; }
    int Perimeter => SideLength * NumberOfSides;
}

class Square : Shape, IRegularPointy
{
    public Square() { }
    public Square(string name) : base(name) { }
    //Draw comes from the Shape base class
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
    //This comes from the IPointy interface
    public byte Points => 4;
    //These come from the IRegularPointy interface
    public int SideLength { get; set; }
    public int NumberOfSides { get; set; }
    //Note that the Perimeter property is not implemented
}

abstract class Shape
{
    public string ShapeName { get; set; }
    protected Shape(string name = "No Name")
    {
        ShapeName = name;
    }

    public abstract void Draw();
}