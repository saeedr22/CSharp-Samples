Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");
IRegularPointy.ExampleProperty = "Updated";
Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");


public interface IPointy
{
    byte Points { get; }
}

interface IRegularPointy : IPointy
{
    int SideLength { get; set; }
    int NumberOfSides { get; set; }
    int Perimeter => SideLength * NumberOfSides;
    //Static members are also allowed in C# 8
    static string ExampleProperty { get; set; }
    static IRegularPointy() => ExampleProperty = "Foo";
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