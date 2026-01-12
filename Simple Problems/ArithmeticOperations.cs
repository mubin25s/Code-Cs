// ArithmeticOperations.cs
namespace SimpleProblems
{
	public static class ArithmeticOperations
	{
		public static void Run()
		{
			int a = 10;
			int b = 3;

			Console.WriteLine($"a = {a}, b = {b}");
			Console.WriteLine($"Addition: {a} + {b} = {a + b}");
			Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
			Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
			Console.WriteLine($"Division: {a} / {b} = {a / (double)b}");
			Console.WriteLine($"Modulus: {a} % {b} = {a % b}");
		}
	}
}
