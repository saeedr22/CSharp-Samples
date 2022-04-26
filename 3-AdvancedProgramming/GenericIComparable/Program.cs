using System;
class Person : IComparable<Person>
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Family { get; set; } = "";

    public int CompareTo(Person? other)
    {
        if (other != null)
            return this.Id.CompareTo(other.Id);
        throw new ArgumentNullException("Other Parameter is null");
        //If I do not use generic , I had to check the type of other in Compare to parameter
        // if (other is Person temp)
        // {
        //     return this.Id.CompareTo(temp.Id);
        // }
    }
}