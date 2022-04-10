
using CustomInterfaces;
string text = "Saeed Rezaei";
OperatingSystem opr = new OperatingSystem(PlatformID.Win32NT, new Version());
CloneMe(text);
CloneMe(opr);

//Sample 01
void CloneMe(ICloneable c)
{
    // Clone whatever we get and print out the name.
    object theClone = c.Clone();
    Console.WriteLine("Your clone is a: {0}",
    theClone.GetType().Name);
}
// as int Interface
// Can we treat hex2 as IPointy?
Hexagon hex1 = new Hexagon("Peter");
IPointy itfPt2 = hex1 as IPointy;
if (itfPt2 != null)
{
    Console.WriteLine("Points: {0}", itfPt2.Points);
}
else
{
    Console.WriteLine("OOPS! Not pointy...");
}
//is In InterFace
//Points: 3
Triangle hex2 = new Triangle("Test");
if (hex2 is IPointy itfPt3)
{
    Console.WriteLine("Points: {0}", itfPt3.Points);
}
else
{
    Console.WriteLine("OOPS! Not pointy...");
}
//OOPS! Not pointy...
Circle circle2 = new Circle("Test");
if (circle2 is IPointy circle)
{
    Console.WriteLine("Points: {0}", circle.Points);
}
else
{
    Console.WriteLine("OOPS! Not pointy...");
}

//Custom Interfaces
namespace CustomInterfaces
{
    // This interface defines the behavior of "having points."
    public interface IPointy
    {
        // Implicitly public and abstract.
        // byte GetNumberOfPoints();
        // Error! Interfaces cannot have data fields!
        //public int numbOfPoints;
        // Error! Interfaces do not have nonstatic constructors!
        //public IPointy() { numbOfPoints = 0;}
        // A read-write property in an interface would look like:
        //string PropName { get; set; }
        // while a read-only property in an interface would be:
        byte Points { get; }
    }

    class Triangle : Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Triangle", ShapeName);
        }
        // IPointy implementation.
        //public byte Points
        //{
        // get { return 3; }
        //}
        public byte Points => 3;
        // public byte GetNumberOfPoints() => 3;
    }

    class Hexagon : Shape, IPointy
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", ShapeName);
        }

        // IPointy implementation.
        public byte Points => 6;
    }

    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name = "No Name") : base(name)
        {
            ShapeName = name;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", ShapeName);
        }
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

}

