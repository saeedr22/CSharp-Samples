//Understanding C# Nullable Types
// Compiler errors!
// Value types cannot be set to null!
// bool myBool = null;
// int myInt = null;

CallDatabaseReader();

#nullable disable
TestClass anotherNullableClass = null;
//Warning CS8632 The annotation for nullable reference types
//should only be used in code within a '#nullable' annotations
TestClass? badDefinition = null;
//Warning CS8632 The annotation for nullable reference types
//should only be used in code within a '#nullable' annotations
string? anotherNullableString = null;
#nullable restore

static void LocalNullableVariables()
{
    // Define some local nullable variables.
    int? nullableInt = 10;
    double? nullableDouble = 3.14;
    bool? nullableBool = null;
    char? nullableChar = 'a';
    int?[] arrayOfNullableInts = new int?[10];
}
static void LocalNullableVariablesUsingNullable()
{
    // Define some local nullable types using Nullable<T>.
    Nullable<int> nullableInt = 10;
    Nullable<double> nullableDouble = 3.14;
    Nullable<bool> nullableBool = null;
    Nullable<char> nullableChar = 'a';
    Nullable<int>[] arrayOfNullableInts = new Nullable<int>[10];
}

void CallDatabaseReader()
{
    Console.WriteLine("***** Fun with Nullable Value Types *****\n");
    DatabaseReader dr = new DatabaseReader();
    // Get int from "database".
    int? i = dr.GetIntFromDatabase();
    if (i.HasValue)
    {
        Console.WriteLine("Value of 'i' is: {0}", i.Value);
    }
    else
    {
        Console.WriteLine("Value of 'i' is undefined.");
    }
    // Get bool from "database".
    bool? b = dr.GetBoolFromDatabase();
    if (b != null)
    {
        Console.WriteLine("Value of 'b' is: {0}", b.Value);
    }
    else
    {
        Console.WriteLine("Value of 'b' is undefined.");
    }

    //omitted for brevity
    Console.WriteLine("***** Fun with Nullable Data *****\n");
    DatabaseReader dr2 = new DatabaseReader();
    // If the value from GetIntFromDatabase() is null,
    // assign local variable to 100.
    int myData = dr2.GetIntFromDatabase() ?? 100;
    Console.WriteLine("Value of myData: {0}", myData);
}

//The Null-Coalescing Assignment Operator (New 8.0)
//Null-coalescing assignment operator
int? nullableInt = null;
nullableInt ??= 12;
nullableInt ??= 14;
//output 12
Console.WriteLine(nullableInt);

//traditional way 
//new way
Console.WriteLine($"You sent me {nullableInt?.ToString()}");
class DatabaseReader
{
    // Nullable data field.
    public int? numericValue = null;
    public bool? boolValue = true;
    // Note the nullable return type.
    public int? GetIntFromDatabase()
    { return numericValue; }
    // Note the nullable return type.
    public bool? GetBoolFromDatabase()
    { return boolValue; }
}

public class TestClass
{
    public string Name { get; set; }
    public int Age { get; set; }
}

