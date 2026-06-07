using System;

namespace A3_Q4Soln
{
    public class Manager : Employee
    {
        public double Bonus { get; set; }

        // Default constructor
        public Manager()
        {
            Designation = "Manager";
        }

        // Parameterized constructor
        public Manager(int id, string name, double bonus)
            : base(id, name)
        {
            Bonus = bonus;
            Designation = "Manager";
        }

        // Accept method
        public override void Accept()
        {
            base.Accept();

            Console.Write("Enter Bonus: ");
            Bonus = Convert.ToDouble(Console.ReadLine());

            Designation = "Manager";
        }

        // Print method
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Bonus: {Bonus}");
        }

        // ToString method
        public override string ToString()
        {
            return base.ToString() + $", Bonus: {Bonus}";
        }
    }
}