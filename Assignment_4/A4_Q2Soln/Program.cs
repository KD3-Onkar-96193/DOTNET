using System;
using System.Reflection;

namespace A4_Q2Soln
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load MathsLib assembly (A4_Q1Soln)
            Assembly asm = typeof(A4_Q1Soln.Maths).Assembly;

            // Create object of Maths class using reflection
            Type mathType = asm.GetType("A4_Q1Soln.Maths");
            object mathObj = Activator.CreateInstance(mathType);

            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Sum");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                    break;

                Console.Write("Enter first number: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                MethodInfo method = null;
                object result = null;

                switch (choice)
                {
                    case 1:
                        method = mathType.GetMethod("Sum");
                        result = method.Invoke(mathObj, new object[] { a, b });
                        Console.WriteLine("Result = " + result);
                        break;

                    case 2:
                        method = mathType.GetMethod("Subtract");
                        result = method.Invoke(mathObj, new object[] { a, b });
                        Console.WriteLine("Result = " + result);
                        break;

                    case 3:
                        method = mathType.GetMethod("Multiply");
                        result = method.Invoke(mathObj, new object[] { a, b });
                        Console.WriteLine("Result = " + result);
                        break;

                    case 4:
                        method = mathType.GetMethod("Divide");
                        result = method.Invoke(mathObj, new object[] { a, b });
                        Console.WriteLine("Result = " + result);
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }

            Console.WriteLine("Program Ended.");
        }
    }
}