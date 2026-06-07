using System;

namespace A3_Q4Soln
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Designation { get; set; }

        public Employee()
        {
            Designation = "Employee";
        }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
            Designation = "Employee";
        }

        public virtual void Accept()
        {
            Console.Write("Enter Id: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
        }

        public virtual void Print()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Designation: {Designation}");
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Designation: {Designation}";
        }
    }
}