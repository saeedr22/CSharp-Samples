Circle c = new Circle();
c.Draw();
class Shape
{
    public void Draw()
    {
        Console.WriteLine("Inside Shape.Draw()");
    }

    public void Test()
    {
        Console.WriteLine("Inside Shape.Test()");
    }
}

// Circle DOES NOT override Draw().
class Circle : Shape
{
    public Circle() { }
    /*  'ThreeDCircle.Draw()' hides inherited member 'Circle.Draw()'. To make the current member 
         override that implementation, add the override keyword. Otherwise add the new keyword.*/

    public void Draw()
    {
        Console.WriteLine("Inside Circle.Draw()");
    }

    //Remove warning by add new keyword
    // Hide any Draw() implementation above me.
    //shadowing
    public new void Test()
    {
        Console.WriteLine("Inside Circle.Test()");
    }

}