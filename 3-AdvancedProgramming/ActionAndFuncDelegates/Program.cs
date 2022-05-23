// Use the Action<> delegate to point to DisplayMessage.
Action<string, ConsoleColor, int> actionTarget =
 DisplayMessage;
actionTarget("Action Message!", ConsoleColor.Yellow, 5);

Func<int, int, int> funcTarget = Add;
Console.WriteLine(funcTarget(10, 20));
// This is a target for the Action<> delegate.
static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
{
    // Set color of console text.
    ConsoleColor previous = Console.ForegroundColor;
    Console.ForegroundColor = txtColor;
    for (int i = 0; i < printCount; i++)
    {
        Console.WriteLine(msg);
    }
    // Restore color.
    Console.ForegroundColor = previous;
}

static int Add(int x, int y)
{
    return x + y;
}