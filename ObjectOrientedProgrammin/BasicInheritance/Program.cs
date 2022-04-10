Console.WriteLine("***** Basic Inheritance *****\n");
// Make a Car object, set max speed and current speed.
Car myCar = new Car(80) { Speed = 50 };
// Print current speed.
Console.WriteLine("My car is going {0} KMH", myCar.Speed);

MiniVan myVan = new MiniVan {Speed = 10};
Console.WriteLine("My van is going {0} MPH", myVan.Speed);

class Car
{
    public readonly int MaxSpeed;
    private int _currSpeed;
    public Car(int max)
    {
        MaxSpeed = max;
    }

    public Car()
    {
        MaxSpeed = 55;
    }
    public int Speed
    {
        get { return _currSpeed; }
        set
        {
            _currSpeed = value;
            if (_currSpeed > MaxSpeed)
            {
                _currSpeed = MaxSpeed;
            }
        }
    }
}

// MiniVan "is-a" Car.
sealed class MiniVan : Car
{ }