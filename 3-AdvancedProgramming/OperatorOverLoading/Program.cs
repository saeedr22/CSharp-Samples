
Car car1 = new Car("Benz");
Car car2 = new Car("BMW");
Car car3 = new Car("Toyota");
car1++;
Car car4 = car1 + car2 + car3;
Console.WriteLine(car4.ToString());
class Car : IComparable
{
    public string Name { get; set; }
    public Car(string name)
    {
        Name = name;
    }
    public static Car operator +(Car car1, Car car2)
        => new Car(car1.Name + " " + car2.Name);
    public static Car operator ++(Car car1)
        => new Car(car1.Name + "Plus");
    public static bool operator ==(Car car1, Car car2)
        => car1.Name.Equals(car2);
    public static bool operator !=(Car car1, Car car2)
        => !car1.Name.Equals(car2);
    public static bool operator <(Car car1, Car car2)
        => car1.CompareTo(car2) < 0;
    public static bool operator >(Car car1, Car car2)
        => car1.CompareTo(car2) > 0;
    public static bool operator <=(Car car1, Car car2)
        => car1.CompareTo(car2) <= 0;
    public static bool operator >=(Car car1, Car car2)
        => car1.CompareTo(car2) >= 0;

    public override string ToString()
    {
        return Name.ToString();
    }

    public int CompareTo(Car? obj)
    {
        return this.Name.CompareTo(obj.Name);
    }
}