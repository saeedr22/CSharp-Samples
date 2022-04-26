
Console.WriteLine("Record type inheritance!");
Car c = new Car("Honda","Pilot","Blue");
MiniVan m = new MiniVan("Honda", "Pilot", "Blue",10);
//return true
Console.WriteLine($"Checking MiniVan is-a Car:{m is Car}");
//return false
Console.WriteLine($"Car and MiniVan are equal: {Equals(m,c)}");

//Car record type
public record Car
{
    public string Make { get; init; }
    public string Model { get; init; }
    public string Color { get; init; }
    public Car(string make, string model, string color)
    {
        Make = make;
        Model = model;
        Color = color;
    }
}

//MiniVan.cs
//MiniVan record type
public sealed record MiniVan : Car
{
    public int Seating { get; init; }
    public MiniVan(string make, string model, string color, int seating) : base(make, model, color)
    {
        Seating = seating;
    }
}
