// ConditionalLogic.cs
namespace SimpleProblems
{
    public static class ConditionalLogic
    {
        public static void Run()
        {
            int score = 85;

            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        }
    }
}
