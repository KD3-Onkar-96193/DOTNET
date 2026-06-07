
using System;
using EmployeeLib;

class Program
{
    static void Main()
    {
        Date d = new Date();

        d.AcceptDate();

        Console.WriteLine("\nEntered Date:");
        d.PrintDate();

        Console.WriteLine("\nIs Valid Date? " + d.IsValid());

        Console.WriteLine("\nToString Output: " + d.ToString());
    }
}