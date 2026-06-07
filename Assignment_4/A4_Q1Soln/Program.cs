using System;
using A4_Q1Soln;

class Program
{
    static void Main()
    {
        Maths m = new Maths();

        Console.WriteLine("Sum: " + m.Sum(10, 5));
        Console.WriteLine("Subtract: " + m.Subtract(10, 5));
        Console.WriteLine("Multiply: " + m.Multiply(10, 5));
        Console.WriteLine("Divide: " + m.Divide(10, 5));
    }
}