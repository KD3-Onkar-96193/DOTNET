using System;

namespace A3_Q5Soln
{
    public class Supervisor : Employee
    {
        // Number of assistants
        public int Subbordinates { get; set; }

        // Default constructor
        public Supervisor()
        {
            Designation = "Supervisor";
        }

        // Parameterized constructor
        public Supervisor(int id, string name, int subbordinates)
            : base(id, name)
        {
            Subbordinates = subbordinates;
            Designation = "Supervisor";
        }

        // Accept method
        public override void Accept()
        {
            base.Accept();

            Console.Write("Enter number of subbordinates: ");
            Subbordinates = Convert.ToInt32(Console.ReadLine());

            Designation = "Supervisor";
        }

        // Print method
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Subbordinates: {Subbordinates}");
        }

        // ToString method
        public override string ToString()
        {
            return base.ToString() + $", Subbordinates: {Subbordinates}";
        }
    }
}