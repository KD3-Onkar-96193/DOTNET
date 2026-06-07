using System;

namespace A4_Q1Soln
{
    public class Maths
    {
        // Sum method
        public int Sum(int a, int b)
        {
            return a + b;
        }

        // Subtract method
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Multiply method
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Divide method
        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return (double)a / b;
        }
    }
}