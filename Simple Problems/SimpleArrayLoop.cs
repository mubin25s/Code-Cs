using System;

namespace SimpleProblem
{
    public static class SimpleArrayLoopRunner
    {
        public static void Run()
        {
            string[] items = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            Console.WriteLine("Processing Items:");

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Length > 5)
                {
                    Console.WriteLine(items[i] + " is a long word");
                }
                else
                {
                    Console.WriteLine(items[i] + " is a short word");
                }
            }
        }
    }