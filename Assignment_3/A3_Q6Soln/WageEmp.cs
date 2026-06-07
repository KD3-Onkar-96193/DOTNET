using System;

namespace A3_Q6Soln
{
    public class WageEmp : Employee
    {
        // Members
        public int Hours { get; set; }
        public int Rate { get; set; }

        // Default constructor
        public WageEmp()
        {
            Designation = "Wage";
        }

        // Parameterized constructor
        public WageEmp(int id, string name, int hours, int rate)
            : base(id, name)
        {
            Hours = hours;
            Rate = rate;
            Designation = "Wage";
        }

        // Accept method
        public override void Accept()
        {
            base.Accept();

            Console.Write("Enter Hours: ");
            Hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Rate per hour: ");
            Rate = Convert.ToInt32(Console.ReadLine());

            Designation = "Wage";
        }

        // Print method
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Hours: {Hours}");
            Console.WriteLine($"Rate per hour: {Rate}");
        }

        // ToString method
        public override string ToString()
        {
            return base.ToString() + $", Hours: {Hours}, Rate: {Rate}";
        }
    }
}