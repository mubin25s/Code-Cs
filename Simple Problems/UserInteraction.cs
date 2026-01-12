// UserInteraction.cs
namespace SimpleProblems
{
    public static class UserInteraction
    {
        public static void Run()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your birth year: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int birthYear))
            {
                int currentYear = DateTime.Now.Year;
                int age = currentYear - birthYear;
                Console.WriteLine($"Hello {name}, you are approximately {age} years old.");
            }
            else
            {
                Console.WriteLine("Invalid year entered.");
            }
        }
    }
}
