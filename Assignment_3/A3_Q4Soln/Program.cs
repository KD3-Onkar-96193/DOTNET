using System;
using EmployeeLib;

namespace A3_Q4Soln
{
    class Program
    {
        static void Main()
        {
            Manager m = new Manager();

            m.Accept();
            m.Print();

            Console.WriteLine(m.ToString());
        }
    }
}