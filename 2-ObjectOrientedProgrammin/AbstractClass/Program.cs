// The abstract base class of the hierarchy.
var circle = new Circle();
circle.Draw();
circle.AreaFrmula();

var hexagon = new Hexagon();
hexagon.Draw();
hexagon.AreaFrmula();

Shape[] shapes = {new Circle("c1"),new Hexagon("h1"),new Circle("c2"),new Hexagon("h2")};
foreach (var shape in shapes)
{
   shape.AreaFrmula();
}
abstract class Shape
{
    public string ShapeName { get; set; }
    protected Shape(string name = "No Name")
    {
        ShapeName = name;
    }
   //  Abstract methods can be defined only in abstract classes. If you attempt to do otherwise, you will be issued a compiler error
    // Force all child classes to define how to be rendered.
    public abstract void AreaFrmula();

    public virtual void Draw()
    {
        Console.WriteLine("Inside Shape.Draw()");
    }
}

// Circle DOES NOT override Draw().
class Circle : Shape
{
    public Circle() { }
    public Circle(string name = "No Name") : base(name)
    {
        ShapeName = name;
    }
    public override void AreaFrmula()
    {
        Console.WriteLine($"{ShapeName} Area = π r²");
    }

}
// Hexagon DOES override Draw().
class Hexagon : Shape
{
    public Hexagon() { }
    public Hexagon(string name) : base(name)
    { }
    public override void Draw()
    {
        Console.WriteLine($"Drawing {ShapeName} the Hexagon");
    }

     public override void AreaFrmula()
    {
        Console.WriteLine($"{ShapeName} Area  = (3√3 s2)/2");
    }
}