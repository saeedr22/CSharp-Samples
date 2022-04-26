Motorcycle c = new Motorcycle(5);
c.SetDriverName("Tiny");
Console.WriteLine("Rider name is {0}", c.name);

// the Role of the this Keyword
class Motorcycle
{
    public int driverIntensity;
    // New members to represent the name of the driver.
    public string name = "";
    public void SetDriverName(string name) => this.name = name;

    //Chaining Constructor Calls Using this

    public Motorcycle()
    {
         Console.WriteLine("In default ctor");
    }
    // This is the 'master' constructor that does all the real work.
    public Motorcycle(int intensity, string name)
    {
        if (intensity > 10)
        {
            intensity = 10;
        }
        driverIntensity = intensity;
        this.name = name;
    }

    public Motorcycle(string name) : this(0, name)
    { 
         Console.WriteLine("In ctor taking a string");
    }
    public Motorcycle(int intensity) : this(intensity, "")
    { 
         Console.WriteLine("In ctor taking an int");
    }
}