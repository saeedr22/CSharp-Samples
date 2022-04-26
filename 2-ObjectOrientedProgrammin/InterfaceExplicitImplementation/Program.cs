Octagon oct = new Octagon();
// We now must use casting to access the Draw()
// members.
IDrawToForm itfForm = (IDrawToForm)oct;
itfForm.Draw();
// Shorthand notation if you don't need
// the interface variable for later use.
((IDrawToPrinter)oct).Draw();
// Could also use the "is" keyword.
if (oct is IDrawToMemory dtm)
{
    dtm.Draw();
}
// Draw image to a form.
interface IDrawToForm
{
    void Draw();
}

// Draw to buffer in memory.
public interface IDrawToMemory
{
    void Draw();
}
// Render to the printer.
public interface IDrawToPrinter
{
    void Draw();
}

class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
{
    // Shared drawing logic.
    // public void Draw()
    // {
    //     Console.WriteLine("Drawing the Octagon...");
    // }
    void IDrawToForm.Draw()
    {
        Console.WriteLine("Drawing to form...");
    }
    void IDrawToMemory.Draw()
    {
        Console.WriteLine("Drawing to memory...");
    }
    void IDrawToPrinter.Draw()
    {
        Console.WriteLine("Drawing to a printer...");
    }

    // Error! No access modifier!
    // public void IDrawToForm.Draw()
    // {
    //     Console.WriteLine("Drawing to form...");
    // }
}