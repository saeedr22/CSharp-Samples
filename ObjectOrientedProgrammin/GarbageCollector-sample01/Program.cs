// Print out estimated number of bytes on heap.
Console.WriteLine("Estimated bytes on heap: {0}",
 GC.GetTotalMemory(false));
// MaxGeneration is zero based, so add 1 for display
// purposes.
Console.WriteLine("This OS has {0} object generations.\n",(GC.MaxGeneration + 1));
Car refToMyCar = new Car("Zippy", 100);
Console.WriteLine(refToMyCar.ToString());

// Print out generation of refToMyCar object.
Console.WriteLine("Generation of refToMyCar is: {0}",
 GC.GetGeneration(refToMyCar));

 // Only investigate generation 0 objects.
GC.Collect(0);
GC.WaitForPendingFinalizers();

//As with any garbage collection, calling GC.Collect() promotes surviving generations. 
Console.WriteLine("Generation of refToMyCar is: {0}",
 GC.GetGeneration(refToMyCar));
class Car 
{
    // Constant for maximum speed.
    public const int MaxSpeed = 100;
    // Car properties.
    public int CurrentSpeed { get; set; } = 0;
    public string PetName { get; set; } = "";

    // Constructors.
    public Car() { }
    public Car(string name, int speed)
    {
        CurrentSpeed = speed;
        PetName = name;
    }

}