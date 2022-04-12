// Two references to same object!
Point p1 = new Point(50, 50);
Point p2 = p1;
p2.X = 0;
Console.WriteLine(p1);
Console.WriteLine(p2);

// Notice Clone() returns a plain object type.
// You must perform an explicit cast to obtain the derived type.
Point p3 = new Point(100, 100);
Point p4 = (Point)p3.Clone();
// Change p4.X (which will not change p3.X).
p4.X = 0;
// Print each object.
Console.WriteLine(p3);
Console.WriteLine(p4);
class Point : ICloneable
{
    public Point() { }
    public Point(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }
    public int X { get; set; }
    public int Y { get; set; }

    // Return a copy of the current object. (Deep Copy)
    public object Clone() => new Point(this.X, this.Y);

    // Copy each field of the Point member by member.
    // public object Clone() => this.MemberwiseClone();
    public override string ToString() => $"X = {X}; Y = {Y}";

}