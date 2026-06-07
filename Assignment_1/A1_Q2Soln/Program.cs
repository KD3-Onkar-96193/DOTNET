using System;

class Calculator
{
    static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Usage: <number1> <operator> <number2>");
            Console.WriteLine("Example: 10 + 5");
            return;
        }

        double num1 = Convert.ToDouble(args[0]);
        string op = args[1];
        double num2 = Convert.ToDouble(args[2]);

        double result = 0;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine("Result = " + result);
                break;

            case "-":
                result = num1 - num2;
                Console.WriteLine("Result = " + result);
                break;

            case "*":
                result = num1 * num2;
                Console.WriteLine("Result = " + result);
                break;

            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Result = " + result);
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                break;

            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
}