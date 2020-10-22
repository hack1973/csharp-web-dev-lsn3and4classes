using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            //Student mike = new Student("Mike");
            //Student bella = new Student("Bella", 2);
            Student sophia = new Student("Sophia",5,29,3.5);
            Student mama = new Student("Mama");
            Student caca = new Student("Caca");
            Teacher john = new Teacher("John", "Bozett", "Java101", 5);
            Course java101 = new Course();
            //mike.Name = "Mike";
            //mike.NumberOfCredits = 1;
            //mike.Gpa = 4.0;
            /*Console.WriteLine(mike.Name);
            Console.WriteLine(mike.StudentId);
            Console.WriteLine(mike.NumberOfCredits);
            Console.WriteLine(mike.Gpa);
            Console.WriteLine(bella.Name);
            Console.WriteLine(bella.StudentId);
            Console.WriteLine(bella.NumberOfCredits);
            Console.WriteLine(bella.Gpa);*/
            Console.WriteLine(sophia.Name);
            Console.WriteLine(sophia.StudentId);
            Console.WriteLine(sophia.NumberOfCredits);
            Console.WriteLine(sophia.Gpa);
            Console.WriteLine(sophia.GetGradeLevel());
            Console.WriteLine(mama.Name);
            Console.WriteLine(mama.StudentId);
            Console.WriteLine(caca.Name);
            Console.WriteLine(caca.StudentId);
            sophia.AddGrade(3, 4.0);
            Console.WriteLine(sophia.NumberOfCredits);
            Console.WriteLine(sophia.Gpa);
            Console.WriteLine(sophia.GetGradeLevel());
            //Console.WriteLine(sophia.ToString());
            Console.WriteLine(sophia);
            Console.WriteLine(john.FirstName);
            Console.WriteLine(java101);
        }
    }
}
