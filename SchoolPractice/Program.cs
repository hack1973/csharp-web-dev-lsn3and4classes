using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student mike = new Student();
            mike.Name = "Mike";
            mike.NumberOfCredits = 1;
            mike.Gpa = 4.0;
            Console.WriteLine(mike.Name);
            Console.WriteLine(mike.StudentId);
            Console.WriteLine(mike.NumberOfCredits);
            Console.WriteLine(mike.Gpa);
        }
    }
}
