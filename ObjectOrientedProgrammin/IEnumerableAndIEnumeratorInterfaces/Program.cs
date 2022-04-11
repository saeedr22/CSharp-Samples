using System.Collections;
// Manually work with IEnumerator.
Garage c = new Garage();
IEnumerator carEnumerator = c.GetEnumerator();
carEnumerator.MoveNext();
Car myCar = (Car)carEnumerator.Current;
Console.WriteLine("{0} is going {1} MPH", myCar.PetName, myCar.CurrentSpeed);
carEnumerator.MoveNext();
myCar = (Car)carEnumerator.Current;
Console.WriteLine("{0} is going {1} MPH", myCar.PetName, myCar.CurrentSpeed);
foreach (Car item in c)
{
    Console.WriteLine(item.PetName);
}
GuardGarage c2 = new GuardGarage();
IEnumerator carEnumerato2 = c2.GetEnumerator();

Console.WriteLine(carEnumerato2.ToString());
foreach (Car item in c2.GetTheCars(false))
{
    Console.WriteLine(item.PetName);
}
Console.WriteLine("Return the items in reverse");
foreach (Car item in c2.GetTheCars(true))
{
    Console.WriteLine(item.PetName);
}


//carEnumerato2.MoveNext();
class Radio
{
    public void TurnOn(bool on)
    {
        Console.WriteLine(on ? "Jamming..." : "Quiet time...");
    }
}
class Car
{
    // Constant for maximum speed.
    public const int MaxSpeed = 100;
    // Car properties.
    public int CurrentSpeed { get; set; } = 0;
    public string PetName { get; set; } = "";
    // Is the car still operational?
    private bool _carIsDead;
    // A car has-a radio.
    private readonly Radio _theMusicBox = new Radio();
    // Constructors.
    public Car() { }
    public Car(string name, int speed)
    {
        CurrentSpeed = speed;
        PetName = name;
    }
    public void CrankTunes(bool state)
    {
        // Delegate request to inner object.
        _theMusicBox.TurnOn(state);
    }

    // See if Car has overheated.
    public void Accelerate(int delta)
    {
        if (_carIsDead)
        {
            Console.WriteLine("{0} is out of order...", PetName);
        }
        else
        {
            CurrentSpeed += delta;
            if (CurrentSpeed > MaxSpeed)
            {
                Console.WriteLine("{0} has overheated!", PetName);
                CurrentSpeed = 0;
                _carIsDead = true;
            }
            else
            {
                Console.WriteLine("=> CurrentSpeed = {0}",
                CurrentSpeed);
            }
        }
    }
}

public class Garage : IEnumerable
{
    // System.Array already implements IEnumerator!
    private Car[] carArray = new Car[4];
    public Garage()
    {
        carArray[0] = new Car("FeeFee", 200);
        carArray[1] = new Car("Clunker", 90);
        carArray[2] = new Car("Zippy", 30);
        carArray[3] = new Car("Fred", 30);
    }
    // Return the array object's IEnumerator.
    public IEnumerator GetEnumerator()
    => carArray.GetEnumerator();
}

//Building Iterator Methods with the yield Keyword
public class GarageYield : IEnumerable
{
    // System.Array already implements IEnumerator!
    private Car[] carArray = new Car[4];
    public GarageYield()
    {
        carArray[0] = new Car("FeeFee", 200);
        carArray[1] = new Car("Clunker", 90);
        carArray[2] = new Car("Zippy", 30);
        carArray[3] = new Car("Fred", 30);
    }
    // Return the array object's IEnumerator.
    public IEnumerator GetEnumerator()
    {
        foreach (var car in carArray)
        {
            yield return car;
        }

        //Ok!
        // public IEnumerator GetEnumerator()
        // {
        //     yield return carArray[0];
        //     yield return carArray[1];
        //     yield return carArray[2];
        //     yield return carArray[3];
        // }
    }
}

//Guard Clauses with Local Functions (New 7.0)
public class GuardGarage : IEnumerable
{
    // System.Array already implements IEnumerator!
    private Car[] carArray = new Car[4];
    public GuardGarage()
    {
        carArray[0] = new Car("FeeFee", 200);
        carArray[1] = new Car("Clunker", 90);
        carArray[2] = new Car("Zippy", 30);
        carArray[3] = new Car("Fred", 30);
    }
    public IEnumerator GetEnumerator()
    {
        //This will not get thrown until MoveNext() is called
        throw new Exception("This won't get called");
        foreach (Car c in carArray)
        {
            yield return c;
        }

    }
    // public IEnumerator GetEnumerator()
    // {
    //     //This will get thrown immediately
    //     throw new Exception("This will get called");
    //     return ActualImplementation();
    //     //this is the local function and the actual IEnumerator implementation
    //     IEnumerator ActualImplementation()
    //     {
    //         foreach (Car c in carArray)
    //         {
    //             yield return c;
    //         }
    //     }
    // }

    public IEnumerable GetTheCars(bool returnReversed)
    {
        //do some error checking here
        return ActualImplementation();
        IEnumerable ActualImplementation()
        {
            // Return the items in reverse.
            if (returnReversed)
            {
                for (int i = carArray.Length; i != 0; i--)
                {
                    yield return carArray[i - 1];
                }
            }
            else
            {
                // Return the items as placed in the array.
                foreach (Car c in carArray)
                {
                    yield return c;
                }
            }
        }
    }
}