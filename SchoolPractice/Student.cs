using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId;
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int sId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int sId)
        {
            Name = name;
            StudentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            StudentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
            Console.WriteLine(nextStudentId);
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double totalQualityScore = Gpa * NumberOfCredits;
            totalQualityScore = totalQualityScore + courseCredits * grade;
            NumberOfCredits = NumberOfCredits + courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            //Freshman(0 - 29 credits), Sophomore(30 - 59 credits), Junior(60 - 89 credits), or Senior(90 + credits)
            if (NumberOfCredits <= 29)
            {
                return "Freshman";
            } 
            else if (NumberOfCredits <= 59)
            {
                return "Sophomore";
            } 
            else if (NumberOfCredits <= 89)
            {
                return "Junior";
            } 
            else
            {
                return "Senior";
            }
        }

        
        public override string ToString()
        {
            return Name + " (Student ID: " + StudentId + ", Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId);
        }
    }
}
