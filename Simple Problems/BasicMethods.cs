// BasicMethods.cs
namespace SimpleProblems
{
    public static class BasicMethods
    {
        public static void Run()
        {
            int result = AddNumbers(15, 25);
            Console.WriteLine($"Result of 15 + 25 is: {result}");

            PrintMessage("C# methods are powerful!");
        }

        private static int AddNumbers(int num1, int num2)
     