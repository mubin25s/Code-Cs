// SimpleClassOOP.cs
Person person1 = new Person("Sachcha", 24);
person1.Introduce();

class Person
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
