Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);
Console.WriteLine("The value of PI is: {0}", MyMathClass.staticPIReadOnly);
// Error! Can't change a constant!
// MyMathClass.PI = 3.1444

class MyMathClass
{
    public const double PI = 3.14;
    // Read-only fields can be assigned in ctors,
    // but nowhere else.
    public readonly double PIReadOnly;
    public static readonly double staticPIReadOnly;

    public MyMathClass()
    {
        PIReadOnly = 3.14;
        
        // Not possible- must assign at time of declaration.
        //***
        // PI = 3.14;
        // staticPIReadOnly = 3.14;
        //***
    }

    // Error!
    // public void ChangePI()
    // { 
    //   PIReadOnly = 3.14444;
    //   PI = 3.14;
    // }
}

