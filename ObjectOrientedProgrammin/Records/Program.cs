//
//***********record types are immutable by default***********
//
DisplayRecord carInfo = new DisplayRecord();
var carRecord = new CarRecord
{
    Make = "Honda",
    Model = "Pilot",
    Color = "Blue"
};
carInfo.Display(carRecord);
carInfo.Display(carRecord);

//Use the custom constructor
CarRecord anotherMyCarRecord = new CarRecord("Honda", "Pilot", "Blue");
Console.WriteLine("Another variable for my car: ");
Console.WriteLine(anotherMyCarRecord.ToString());

//Understanding Equality with Record Types
Console.WriteLine($"Cars are the same? {carRecord.Equals(anotherMyCarRecord)}");
Console.WriteLine($"Cars are the same reference? {ReferenceEquals(carRecord, anotherMyCarRecord)}");

Console.WriteLine($"CarRecords are the same? {carRecord == anotherMyCarRecord}");
Console.WriteLine($"CarRecords are not the same? {carRecord != anotherMyCarRecord}");

//copy
CarRecord ourOtherCar = carRecord with {Model = "Odyssey"};
Console.WriteLine("My copied car:");
Console.WriteLine(ourOtherCar.ToString());
Console.WriteLine($"Cars are the same? {carRecord.Equals(ourOtherCar)}");
record CarRecord
{
    public string Make { get; init; } = "";
    public string Model { get; init; } = "";
    public string Color { get; init; } = "";
    public CarRecord(string make, string model, string color)
    {
        Make = make;
        Model = model;
        Color = color;
    }

    public CarRecord() { }
    public void ChangeValue()
    {
        //error
        //in the record type Properties are init-only
        //Make = "test";
    }
}

class DisplayRecord
{
    public void Display(CarRecord car)
    {
        Console.WriteLine($"make :{car.Make} model:{car.Model} color:{car.Color}");
    }
}
