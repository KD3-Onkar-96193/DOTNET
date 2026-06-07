using System;
using A3_Q6Soln;

class Program
{
    static void Main()
    {
        WageEmp w = new WageEmp();

        Console.WriteLine("Enter Wage Employee Details:");
        w.Accept();

        Console.WriteLine("\n--- Employee Data ---");
        w.Print();

        Console.WriteLine("\nToString Output:");
        Console.WriteLine(w.ToString());
    }
}