using System;
using A3_Q3Soln.Enums;

namespace A3_Q3Soln.Models
{
    public class Employee : Person
    {
        private static int count = 0;

        public int Id { get; private set; }
        public double Salary { get; set; }
        public string Designation { get; set; }
        public DepartmentType Dept { get; set; }

        // Default constructor
        public Employee()
        {
            Id = ++count;
            Salary = 0;
            Designation = "";
            Dept = DepartmentType.IT;
        }

        // Parameterized constructor
        public Employee(string name, bool gender, DateTime birth, string address,
                        double salary, string designation, DepartmentType dept)
            : base(name, gender, birth, address)
        {
            Id = ++count;
            Salary = salary;
            Designation = designation;
            Dept = dept;
        }

        public override void Accept()
        {
            base.Accept();

            Console.Write("Enter Salary: ");
            Salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Designation: ");
            Designation = Console.ReadLine();

            Console.WriteLine("Enter Department (HR, IT, Finance, Sales, Marketing, Operations): ");
            Dept = (DepartmentType)Enum.Parse(typeof(DepartmentType), Console.ReadLine(), true);
        }

        public override void Print()
        {
            base.Print();

            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Designation: {Designation}");
            Console.WriteLine($"Department: {Dept}");
        }

        public override string ToString()
        {
            return $"Id={Id}, Name={Name}, Salary={Salary}, Designation={Designation}, Dept={Dept}";
        }
    }
}