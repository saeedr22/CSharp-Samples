// Call from object level.
BitmapImage myBitmap = new BitmapImage();
myBitmap.Draw();
myBitmap.DrawInBoundingBox(10, 10, 100, 150);
myBitmap.DrawUpsideDown();
// Get IAdvancedDraw explicitly.
if (myBitmap is IAdvancedDraw iAdvDraw)
{
    iAdvDraw.DrawUpsideDown();
}
// Get IDrawable explicitly.
if (myBitmap is IDrawable iDrawable)
{
    // error
    // iDrawable.DrawUpsideDown();
    iDrawable.Draw();
}
public interface IDrawable
{
    void Draw();
}

public interface IAdvancedDraw : IDrawable
{
    void DrawInBoundingBox(int top, int left, int bottom, int right);
    void DrawUpsideDown();
}

public class BitmapImage : IAdvancedDraw
{
    public void Draw()
    {
        Console.WriteLine("Drawing...");
    }
    public void DrawInBoundingBox(int top, int left, int bottom, int right)
    {
        Console.WriteLine("Drawing in a box...");
    }
    public void DrawUpsideDown()
    {
        Console.WriteLine("Drawing upside down!");
    }
}