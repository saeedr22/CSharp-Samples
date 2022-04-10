// A Manager "is-a" System.Object, so we can
// store a Manager reference in an object variable just fine.
object frank = new Manager("Frank", "Zappa", 35, 40000);
//cannot convert from 'object' to 'Employee' 
//GivePromotion(frank);
GivePromotion((Manager)frank);

// A Manager "is-an" Employee too.
Employee moonUnit = new Manager("MoonUnit", "Zappa", 20, 3000);
GivePromotion(moonUnit);




static void GivePromotion(Employee emp)
{
    // Increase pay...
    // Give new parking space in company garage...
    Console.WriteLine("{0} was promoted!", emp.Name);
}

class Employee
{
    public string Name { get; set; }
    public string Family { get; set; }
    public int Age { get; set; }
    public Employee(string name, string family, int age)
    {
        Name = name;
        Family = family;
        Age = age;
    }
}

class Manager : Employee
{
    public float CurrPay { get; set; }
    public Manager(string name, string family, int age, float currPay) : base(name, family, age)
    {
        CurrPay = currPay;
    }
}