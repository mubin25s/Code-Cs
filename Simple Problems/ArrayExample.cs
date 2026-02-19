// ArrayExample.cs
namespace SimpleProblems
{
    public static class ArrayExample
    {
        public static void Run()
        {
            string[] fruits = { "Apple", "Banana", "Cherry", "Date" };

            Console.WriteLine($"Total fruits: {fruits.Length}");
            Console.WriteLine("Fruits list:");

            foreach (string fruit in fruits)
            {
                Con.WriteLine($"- {fruit}");
            }

            fruits[1] = "Blueberry";
            Console.WriteLine($"\nUpdated second fruit: {fruits[1]}");
        }
    }
}
