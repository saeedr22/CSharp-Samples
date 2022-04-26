Car car = new Car();
car.SpeedUp(5);

Car Benz = new Car("Benz");
Car BMW = new Car("BMW", 10);

bool inDanger;
Car Audi = new Car("Audi", 200, out inDanger);

Console.WriteLine(inDanger.ToString());

public class Car
{
    //Default Constructor
    public Car()
    {
        carName = "Philip";
        carSpeed = 5;
    }
    //Custom Constructor - constructor overloading
    public Car(string Name, int Speed)
    {
        carName = Name;
        carSpeed = Speed;
    }
    //Constructors As Expression-Bodied Members (New 7.0)
    public Car(string Name) => carName = Name;
    //Constructors with out Parameters (New 7.3)
    public Car(string Name, int Speed, out bool inDanger)
    {
        carName = Name;
        carSpeed = Speed;
        if (Speed > 100)
            inDanger = true;
        else
            inDanger = false;
    }

    private string carName;
    private int carSpeed;

    public void SpeedUp(int speed)
    {
        carSpeed += 5;
        Console.WriteLine($"Car Speed Is {carSpeed}");
    }

    public void SpeedDown(int speed)
    {
        carSpeed -= 5;
    }
}