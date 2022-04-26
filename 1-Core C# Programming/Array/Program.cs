SystemArrayFunctionality();

void SystemArrayFunctionality()
{
    var persons = new string[] { "Saeed", "Reza", "Hamed", "Ali", "Mohammad", "Hosein" };
    foreach (var item in persons)
    {
        Console.WriteLine(item);
    }
    // Clear out all but the first member.
    Array.Clear(persons, 0, 2);
    foreach (var item in persons)
    {
        Console.WriteLine(item);
    }

    //c# 8 : The range operator specifies a start and end index and allows for access to a subsequence within a list. 
    foreach (var item in persons[0..2])
    {
        Console.WriteLine(item);
    }
    Range range = 0..2;
    foreach (var item in persons[range])
    {
        Console.WriteLine(item);
    }

    Console.WriteLine($"Last item is : {persons[^1]}");
    Console.WriteLine($"Last-1 item is : {persons[^2]}");

    var index = new Index(1, true);
    //OR
    Index indexStruct = ^1;
    //OR
    var indexShortHand = ^1;
    //OR
    Index last = 5;

    Console.WriteLine($"Last item is : {persons[index]} , {persons[indexStruct]} , {persons[indexShortHand]} , {persons[last]}");

    //RAnge Samples
    var skip2CharactersAndTake2Characters = persons[2..4]; // صرفنظر کردن از دو عنصر اول و سپس انتخاب دو عنصر
    var skipFirstAndLastCharacter = persons[1..^1]; // صرفنظر کردن از دو عنصر اول و آخر
    var last3Characters = persons[^3..]; // انتخاب بازه‌ای شامل سه عنصر آخر
    var first4Characters = persons[0..4]; // دریافت بازه‌ای از 4 عنصر اول
    var rangeStartFrom2 = persons[2..]; // دریافت بازه‌ای شروع شده از المان دوم تا آخر
    var skipLast3Characters = persons[..^3]; // صرفنظر کردن از سه المان آخر
    var rangeAll = persons[..]; // انتخاب کل بازه

    var numbers = Enumerable.Range(1, 10).ToArray();
    Print(1..3, numbers); // 1..3 => 2, 3
    Print(..3, numbers);      // 0..3 => 1, 2, 3
    Print(3.., numbers);      // 3..^0 => 4, 5, 6, 7, 8, 9, 10
    Print(1..^1, numbers);    // 1..^1 => 2, 3, 4, 5, 6, 7, 8, 9
    Print(^2..^1, numbers);   // ^2..^1 => 9
}

void Print(Range range, int[] array)
{
    Console.WriteLine(array[range]);
}