var car1 = new { Id = 1, Name = "Car", Color = "white" };
var car2 = new { Id = 1, Name = "Car", Color = "white" };
Console.WriteLine($"You have a {car1.Color} {car1.Name} ");
ReflectOverAnonymousType(car1);
ReflectOverAnonymousType(car2);

EqualityTest();

void ReflectOverAnonymousType(object obj)
{
    Console.WriteLine("obj is an instance of: {0}",
    obj.GetType().Name);
    Console.WriteLine("Base class of {0} is {1}",
    obj.GetType().Name, obj.GetType().BaseType);
    Console.WriteLine("obj.ToString() == {0}", obj.ToString());
    Console.WriteLine("obj.GetHashCode() == {0}",
    obj.GetHashCode());
    Console.WriteLine();
}

static void EqualityTest()
{
    // Make 2 anonymous classes with identical name/value pairs.
    var firstCar = new
    {
        Color = "Bright Pink",
        Make = "Saab",
        CurrentSpeed = 55
    };
    var secondCar = new
    {
        Color = "Bright Pink",
        Make = "Saab",
        CurrentSpeed = 55
    };
    // Are they considered equal when using Equals()?
    if (firstCar.Equals(secondCar))
    {
        Console.WriteLine("Same anonymous object!");
    }
    else
    {
        Console.WriteLine("Not the same anonymous object!");
    }
    // Are they considered equal when using ==?
    // No => '==' check in reference 
    if (firstCar == secondCar)
    {
        Console.WriteLine("Same anonymous object!");
    }
    else
    {
        Console.WriteLine("Not the same anonymous object!");
    }
    // Are these objects the same underlying type?
    if (firstCar.GetType().Name == secondCar.GetType().Name)
    {
        Console.WriteLine("We are both the same type!");
    }
    else
    {
        Console.WriteLine("We are different types!");
    }
}
