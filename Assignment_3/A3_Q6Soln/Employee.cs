using System;

namespace A3_Q6Soln
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        // Default constructor
        public Employee()
        {
            Designation = "Employee";
        }

        // Parameterized constructor
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
            Designation = "Employee";
        }

        // Accept method
        public virtual void Accept()
        {
            Console.Write("Enter Id: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
        }

        // Print method
        public virtual void Print()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Designation: {Designation}");
        }

        // ToString
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Designation: {Designation}";
        }
    }
}