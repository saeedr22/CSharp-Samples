// A custom enumeration.
TestEnum t = new TestEnum();
class TestEnum
{
    public TestEnum()
    {
        EmpTypeEnum emp = EmpTypeEnum.Contractor;
        Console.WriteLine("emp is a {0}.", emp.ToString());
    }
}
enum EmpTypeEnum
{
    Manager, // = 0
    Grunt, // = 1
    Contractor, // = 2
    VicePresident // = 3
}
// Begin with 102.
enum EmpTypeEnum2
{
    Manager = 102,
    Grunt, // = 103
    Contractor, // = 104
    VicePresident // = 105
}
// Elements of an enumeration need not be sequential!
enum EmpType
{
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VicePresident = 9
}
// Compile-time error! 999 is too big for a byte!
enum EmpTypeBySize : byte
{
    Manager = 10,
    Grunt = 1,
    Contractor = 100
    //VicePresident = 999
}
