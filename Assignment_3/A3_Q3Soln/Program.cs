using System;
using A3_Q3Soln.Models;

namespace A3_Q3Soln
{
    class Program
    {
        static void Main()
        {
            Employee emp = new Employee();

            emp.Accept();

            Console.WriteLine("\n--- Employee Details ---");
            emp.Print();

            Console.WriteLine("\nToString Output:");
            Console.WriteLine(emp.ToString());
        }
    }
}