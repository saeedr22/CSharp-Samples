Car car = new Car(10, 110, "Benz ");
car.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
car.RegisterWithCarEngine(OnCarEngineEvent2);

car.Accelerate(50);
car.Accelerate(40);
car.Accelerate(40);
car.Accelerate(1);

void OnCarEngineEvent(string msgForCaller)
{
    Console.WriteLine(msgForCaller);
}

void OnCarEngineEvent2(string msgForCaller)
{
    Console.WriteLine(msgForCaller.ToUpper());
}


public class Car
{
    public int CurrentSpeed { get; set; }
    public int MaxSpeed { get; set; }
    public string PetName { get; set; } = "";

    // Is the car alive or dead?
    private bool _carIsDead;
    public Car()
    { }
    public Car(int currentSpeed, int maxSpeed, string petName)
    {
        CurrentSpeed = currentSpeed;
        MaxSpeed = maxSpeed;
        PetName = petName;
    }

    // 1) Define a delegate type.
    public delegate void CarEngineHandler(string msgForCaller);
    // 2) Define a member variable of this delegate.
    private CarEngineHandler? _listOfHandlers = null;

    // 3) Add registration function for the caller.
    public void RegisterWithCarEngine(CarEngineHandler methodToCall)
    {
        //_listOfHandlers = methodToCall;
        //use + fort multi casting 
        _listOfHandlers += methodToCall;
        //Remove
        //  _listOfHandlers += methodToCall;

    }

    // 4) Implement the Accelerate() method to invoke the delegate's
    // invocation list under the correct circumstances.
    public void Accelerate(int delta)
    {
        // If this car is "dead," send dead message.
        if (_carIsDead)
        {
            _listOfHandlers?.Invoke("Sorry, this car is dead...");
        }
        else
        {
            CurrentSpeed += delta;
            // Is this car "almost dead"?
            if (10 == (MaxSpeed - CurrentSpeed))
            {
                _listOfHandlers?.Invoke("Careful");
            }
            if (CurrentSpeed >= MaxSpeed)
            {
                _carIsDead = true;
            }
            else
            {
                Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}