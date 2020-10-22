using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student mike = new Student("Mike");
            Student bella = new Student("Bella",2);
            Student sophia = new Student("Sophia",5,35,3.5);
            Student mama = new Student("Mama");
            //mike.Name = "Mike";
            //mike.NumberOfCredits = 1;
            //mike.Gpa = 4.0;
            Console.WriteLine(mike.Name);
            Console.WriteLine(mike.StudentId);
            Console.WriteLine(mike.NumberOfCredits);
            Console.WriteLine(mike.Gpa);
            Console.WriteLine(bella.Name);
            Console.WriteLine(bella.StudentId);
            Console.WriteLine(bella.NumberOfCredits);
            Console.WriteLine(bella.Gpa);
            Console.WriteLine(sophia.Name);
            Console.WriteLine(sophia.StudentId);
            Console.WriteLine(sophia.NumberOfCredits);
            Console.WriteLine(sophia.Gpa);
            Console.WriteLine(mama.Name);
            Console.WriteLine(mama.StudentId);
        }
    }
}
