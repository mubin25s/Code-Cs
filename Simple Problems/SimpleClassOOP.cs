// SimpleClassOOP.cs
namespace SimpleProblems
{
    public static class SimpleClassOOP
    {
        public static void Run()
        {
            Person person1 = new Person("Sachcha", 24);
            person1.Introduce();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} and I am {Age} years old.");
        }
    }
}
