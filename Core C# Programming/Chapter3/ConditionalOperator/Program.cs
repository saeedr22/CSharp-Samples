// See https://aka.ms/new-console-template for more information
ExecuteIfElseUsingConditionalOperator();
ConditionalRefExample();
SwitchWithGoto();

void ExecuteIfElseUsingConditionalOperator()
{
    string stringData = "My textual data";
    Console.WriteLine(stringData.Length > 0
    ? "string is greater than 0 characters"
    : "string is not greater than 0 characters");
    Console.WriteLine();
}

void ConditionalRefExample()
{
    var smallArray = new int[] { 1, 2, 3, 4, 5 };
    var largeArray = new int[] { 10, 20, 30, 40, 50 };
    int index = 7;
    ref int refValue = ref ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]);
    refValue = 2000;
    index = 2;
    ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]) = 100;
    Console.WriteLine(string.Join(" ", smallArray));
    Console.WriteLine(string.Join(" ", largeArray));
}
bool b = true;
switch (b)
{
    case true:
        Console.WriteLine("It’s the weekend!");
        break;
    case false:
        Console.WriteLine("It’s the weekend!");
        break;
}

// 'goto' pretty universally thought of as an anti-pattern and not generally used
void SwitchWithGoto()
{
    var foo = 5;
    switch (foo)
    {
        case 1:
            //do something
            goto case 2;
        case 2:
            //do something else
            break;
        case 3:
            //yet another action
            goto default;
        default:
            //default action
            break;
    }
}

object choice;
string? input = "1";//Console.ReadLine();
switch (input)
{
    case "1":
        choice = 1;
        break;
    case "11":
        choice = 2;
        break;
    case "2":
        choice = "Two";
        break;
    case "3":
        choice = 4.5m;
        break;
    default:
        choice = 4.2f;
        break;

}

switch (choice)
{
    case int i when i == 1:
        Console.WriteLine($"{i} is an integer Its value is equal to 1 ");
        break;
    case int i when i == 2:
        Console.WriteLine($"{i} is an integer and Its value is equal to 2 ");
        break;
    case string s:
        Console.WriteLine($"{s} is a string.");
        break;
    case decimal d:
        Console.WriteLine($"{d} is a decimal.");
        break;
    default:
        Console.WriteLine("Your choice is something else");
        break;
}

FromRainbow("Red");
string FromRainbow(string colorBand)
{
    var s = colorBand switch
    {
        "Red" => "#FF0000",
        "Orange" => "#FF7F00",
        "Yellow" => "#FFFF00",
        "Green" => "#00FF00",
        "Blue" => "#0000FF",
        "Indigo" => "#4B0082",
        "Violet" => "#9400D3",
        _ => "#FFFFFF"
    };
    return s;
}

FullName("vahid","farajzadeh");
//Switch expression with Tuples
string FullName(string name, string family)
{
    return (name, family) switch
    {
        ("saeed", "rezaei") => "SaeedRezaei",
        ("vahid", "farajzadeh") => "VahidFarajzadeh",
        ("mohammad", "nori") => "MohammadNori",
        ("milad", "shahbazi") => "MiladShahbazi",
        (_, _) => "anonymous"
    };
}
