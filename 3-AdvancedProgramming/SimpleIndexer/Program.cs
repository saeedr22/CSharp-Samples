

using System.Collections;
PersonCollection p = new PersonCollection();
p[0] = new Person { Id = 1, Name = "Saeed", Family = "Rezaei" };
Console.WriteLine(p[0].Id + " " + p[0].Name + " " + p[0].Family);
class PersonCollection : IEnumerable
{
    private ArrayList persons = new ArrayList();
    public Person this[int index]
    {
        get => (Person)persons[index];
        set => persons.Insert(index, value);
    }
     public Person this[string name]
    {
        get => (Person)persons[name];
        set => persons.Insert(name, value);
    }

    public IEnumerator GetEnumerator()
    {
        return persons.GetEnumerator();
    }
}

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
}