
// Static members of System.Object.
Person p3 = new Person("Sally", "Jones");
Person p4 = new Person("Sally", "Jones");

Person p5 = p3;
p5.Family = "test";
Console.WriteLine("P3 and P4 have same state: {0}", p3.Equals(p4));//false
Console.WriteLine("P3 and P4 have same state: {0}", object.Equals(p3, p5));//true
Console.WriteLine("P3 and P4 are pointing to same object: {0}", object.ReferenceEquals(p3, p4));//false
Console.WriteLine("P3 and P4 are pointing to same object: {0}", object.ReferenceEquals(p3, p5));//true
class Person
{
    public Person(string name, string family)
    {
        Name = name;
        Family = family;
    }
    public string Name { get; set; }
    public string Family { get; set; }
}


//Note : the Equals works only on object instances. The ReferenceEquals method is static