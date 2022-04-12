var car = new List<Car>
{
    new Car() { Id = 2, PetName = "Car1", CurrentSpeed =100},
    new Car() { Id = 1, PetName = "Car2", CurrentSpeed = 120 },
    new Car() { Id = 3, PetName = "Car3", CurrentSpeed = 130 }
};
car.Sort();
class Car : IComparable
{
    // Constant for maximum speed.
    public const int MaxSpeed = 100;
    // Car properties.
    public int CurrentSpeed { get; set; } = 0;
    public string PetName { get; set; } = "";
    public int Id { get; set; } = 0;

    // Constructors.
    public Car() { }
    public Car(string name, int speed, int id)
    {
        CurrentSpeed = speed;
        PetName = name;
        Id = id;
    }

    public int CompareTo(object? otherCar)
    {
        if (otherCar is Car car)
        {
            if (Id > car.Id)
                return 1;
            if (Id == car.Id)
                return 0;
            else return -1;
        }
        throw new ArgumentException("other car is not a Car");
        // if (otherCar is Car temp)
        // {
        //     return this.Id.CompareTo(temp.Id);

        // }
    }
}