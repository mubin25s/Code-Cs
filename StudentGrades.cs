using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeProblem
{
    // Problem: Create a Grade Calculator
    // 1. Store student names and grades.
    // 2. add a method to Calculate Average.
    // 3. add a method to determine Letter Grade (A, B, C, D, F).

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public Student(string name)
        {
            Name = name;
            Grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                Grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Grade must be between 0 and 100.");
            }
        }

        public double CalculateAverage()
        {
            if (Grades.Count == 0) return 0;
            return Grades.Average();
        }

        public char GetLetterGrade()
        {
            double avg = CalculateAverage();
            if (avg >= 90) return 'A';
            if (avg >= 80) return 'B';
            if (avg >= 70) return 'C';
            if (avg >= 60) return 'D';
            return 'F';
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* 
               Simple demonstration of the Student class.
               You can expand this to accept user input.
            */
            
            Student student = new Student("Alice");
            student.AddGrade(85);
            student.AddGrade(92);
            student.AddGrade(78);

            Console.WriteLine($"Student: {student.Name}");
            Console.WriteLine($"Average: {student.CalculateAverage():F2}");
            Console.WriteLine($"Letter Grade: {student.GetLetterGrade()}");
            
            // Expected Output:
            // Student: Alice
            // Average: 85.00
            // Letter Grade: B
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
