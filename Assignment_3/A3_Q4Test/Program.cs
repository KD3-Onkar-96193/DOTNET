using System;
using A3_Q4Soln;

namespace A3_Q4Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();

            Console.WriteLine("Enter Manager Details:");
            m.Accept();

            Console.WriteLine("\n--- Manager Data ---");
            m.Print();

            Console.WriteLine("\nToString Output:");
            Console.WriteLine(m.ToString());

            Console.ReadLine();
        }
    }
}