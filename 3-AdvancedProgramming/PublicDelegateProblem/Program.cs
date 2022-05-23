
Car myCar = new Car();
// We have direct access to the delegate!
myCar.ListOfHandlers = CallWhenExploded;
myCar.Accelerate(10);
// We can now assign to a whole new object...
// confusing at best.
myCar.ListOfHandlers = CallHereToo;
myCar.Accelerate(10);
// The caller can also directly invoke the delegate!
myCar.ListOfHandlers.Invoke("hee, hee, hee...");


void CallWhenExploded(string msg)
{
    Console.WriteLine(msg);
}
void CallHereToo(string msg)
{
    Console.WriteLine(msg);
}
public class Car
{
    public delegate void CarEngineHandler(string msg);
    public CarEngineHandler ListOfHandlers;

    // Just fire out the Exploded notification.
    public void Accelerate(int delta)
    {
        if (ListOfHandlers != null)
        {
            ListOfHandlers("Sorry, this car is dead...");
        }
    }
}