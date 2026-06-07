using System;

using CollegeStudent = College.StudentInfo.Student;
using SchoolStudent = School.StudentInfo.Student;

namespace College.StudentInfo
{
    class Student
    {
        public void ShowDetails()
        {
            Console.WriteLine("This Student class belongs to College.StudentInfo namespace.");
        }
    }
}

namespace School.StudentInfo
{
    class Student
    {
        public void ShowDetails()
        {
            Console.WriteLine("This Student class belongs to School.StudentInfo namespace.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CollegeStudent collegeStudent = new CollegeStudent();
        collegeStudent.ShowDetails();

        SchoolStudent schoolStudent = new SchoolStudent();
        schoolStudent.ShowDetails();
    }
}