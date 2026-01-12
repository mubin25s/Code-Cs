// ListCollection.cs
using System;
using System.Collections.Generic;

namespace SimpleProblems
{
    public static class ListCollection
    {
        public static void Run()
        {
            List<string> cities = new List<string> { "Dhaka", "Chattogram", "Sylhet" };

            cities.Add("Rajshahi");
            cities.Remove("Sylhet");

            Console.WriteLine("Cities in Bangladesh:");
            foreach (var city in cities)
            {
                Console.WriteLine($"- {city}");
            }

            Console.WriteLine($"Number of cities: {cities.Count}");
        }
    }
}
