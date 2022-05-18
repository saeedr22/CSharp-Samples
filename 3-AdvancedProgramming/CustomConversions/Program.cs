
Rectangle rec = new Rectangle(10, 20);
rec.Draw();
Console.WriteLine($"rectangle height :{rec.Height} , width:{rec.Width}");
Console.Write("\n\n\n");
Square sqr = (Square)rec;
sqr.Draw();
Console.WriteLine($"square length :{sqr.Length}");
rec = sqr;//implicit convert
rec.Draw();
class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
    public Rectangle()
    { }

    public void Draw()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }

    public override string ToString()
        => $"[Width = {Width}; Height = {Height}]";

    public static implicit operator Rectangle(Square sqr)
    {
        Rectangle r = new Rectangle
        {
            Height = sqr.Length,
            Width = sqr.Length * 2
        };
        return r;
    }
}

class Square
{
    public int Length { get; set; }

    public Square(int length)
    {
        Length = length;
    }

    public void Draw()
    {
        for (int i = 0; i < Length; i++)
        {
            for (int j = 0; j < Length; j++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }

    public override string ToString() => $"[Length = {Length}]";

    // Rectangles can be explicitly converted into Squares
    public static explicit operator Square(Rectangle r)
    {
        Square sqr = new Square(r.Height);
        return sqr;
    }
}