
using static Employee;

Employee emp = new Employee("Marvin", 45, 123, EmployeePayTypeEnum.Salaried);
Console.WriteLine(emp.Pay);
emp.GiveBonus(100);
Console.WriteLine(emp.Pay);
//----------------------------------------------------------------------------

Garage g = new Garage();
// OK, prints default value of zero.
Console.WriteLine("Number of Cars: {0}", g.NumberOfCars);
// Runtime error! Backing field is currently null!
Console.WriteLine(g.MyAuto.PetName);

class Employee
{
    // Field data.
    private string _empName;
    private int _empId;
    private float _currPay;
    // Properties!
    public string Name
    {
        get { return _empName; }
        set
        {
            if (value.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            }
            else
            {
                _empName = value;
            }
        }
    }
    // Properties As Expression-Bodied Members (New 7.0)
    public int Id
    {
        get => _empId;
        set => _empId = value;
    }
    public float Pay
    {
        get { return _currPay; }
        set { _currPay = value; }
    }

    //Pattern Matching with Property Patterns (New 8.0)
    public enum EmployeePayTypeEnum
    {
        Hourly,
        Salaried,
        Commission
    }
    private EmployeePayTypeEnum _payType;
    public EmployeePayTypeEnum PayType
    {
        get => _payType;
        set => _payType = value;
    }
    public Employee(string name, int id, float pay)
     : this(name, id, pay, EmployeePayTypeEnum.Hourly)
    {
    }
    public Employee(string name, int id, float pay, EmployeePayTypeEnum payType)
    {
        Id = id;
        Name = name;
        Pay = pay;
        PayType = payType;
    }


    public void GiveBonus(float amount)
    {
        Pay = this switch
        {
            { PayType: EmployeePayTypeEnum.Commission }
            => Pay += .10F * amount,
            { PayType: EmployeePayTypeEnum.Hourly }
            => Pay += 40F * amount / 2080F,
            { PayType: EmployeePayTypeEnum.Salaried }
            => Pay += amount,
            _ => Pay += 0
        };
    }
}

class Garage
{
    // The hidden int backing field is set to zero!
    public int NumberOfCars { get; set; }
    // The hidden Car backing field is set to null!
    public Car MyAuto { get; set; }
    // The hidden backing field is set to a new Car object.
    public Car MyAutoDefaultValue { get; set; } = new Car();
}

class Car
{
    // Automatic properties!
    public string PetName { get; set; }
    public int Speed { get; set; }
    public string Color { get; set; }
    public void DisplayStats()
    {
        Console.WriteLine("Car Name: {0}", PetName);
        Console.WriteLine("Speed: {0}", Speed);
        Console.WriteLine("Color: {0}", Color);
    }
}



