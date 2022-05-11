using System;
using System.Security.AccessControl;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

ObservableCollection<Person> persons = new ObservableCollection<Person>
{
   new Person{Id=1,Name="Saeed",Family="Rezaei"},
   new Person{Id=1,Name="Amin",Family="Rezaei"}
};

persons.CollectionChanged += Persons_Changd;

// Now add a new item.
persons.Add(new Person { Id = 1, Name = "Ahmad", Family = "Rezaei" });
// Remove an item.
persons.RemoveAt(0);

void Persons_Changd(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
{
    // What was the action that caused the event?
    Console.WriteLine("Action for this event: {0}", e.Action);
    // They removed something.
    if (e.Action == NotifyCollectionChangedAction.Remove)
    {
        Console.WriteLine("Here are the OLD items:");
        foreach (Person p in e.OldItems)
        {
            Console.WriteLine(p.ToString());
        }
        Console.WriteLine();
    }
    // They added something.
    if (e.Action == NotifyCollectionChangedAction.Add)
    {
        // Now show the NEW items that were inserted.
        Console.WriteLine("Here are the NEW items:");

        foreach (Person p in e.NewItems)
        {
            Console.WriteLine(p.ToString());
        }
    }
}
class Person
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Family { get; set; } = "";

    public override string ToString()
    {
        return Name + " " + Family;
    }
}
