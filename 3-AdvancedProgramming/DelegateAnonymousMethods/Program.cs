

Car car = new Car(10, 100, "Benz");
car.AboutToBlow += delegate (object sender, CarEventArgs e)
{
    Console.WriteLine($"{sender} say {e.Message}");
};
for (int i = 0; i < 6; i++)
{
    car.Accelerate(20);
}
Console.ReadLine();

public class Car
{
    public event EventHandler<CarEventArgs> Exploded;
    public event EventHandler<CarEventArgs> AboutToBlow;
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
    public void Accelerate(int delta)
    {
        // If the car is dead, fire Exploded event.
        if (_carIsDead)
        {
            Exploded?.Invoke(this, new CarEventArgs("Sorry, this car is dead..."));
        }

        else
        {
            CurrentSpeed += delta;
            // Almost dead?
            if (10 == MaxSpeed - CurrentSpeed)
            {
                AboutToBlow?.Invoke(this, new CarEventArgs("Careful buddy! Gonna blow!"));
            }
            // Still OK!
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

public class CarEventArgs : EventArgs
{
    public readonly string Message;
    public CarEventArgs(string message)
    {
        Message = message;
    }
}