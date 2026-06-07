using System;
using EmployeeLib;

class Program
{
    static void Main()
    {
        Person p = new Person();

        p.Accept();

        Console.WriteLine("\nDisplaying Data:");
        p.Print();

        Console.WriteLine("\nToString Output:");
        Console.WriteLine(p.ToString());
    }
}