// BasicMethods.cs
int result = AddNumbers(15, 25);
Console.WriteLine($"Result of 15 + 25 is: {result}");

PrintMessage("C# methods are powerful!");

static int AddNumbers(int num1, int num2)
{
    return num1 + num2;
}

static void PrintMessage(string message)
{
    Console.WriteLine(message);
}
