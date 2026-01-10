// ErrorHandling.cs
try
{
    int x = 10;
    int y = 0;
    int result = x / y;
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: Cannot divide by zero.");
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}
finally
{
    Console.WriteLine("Execution of block completed.");
}
