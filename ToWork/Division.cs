using System;

namespace ArithmeticPractice
{
    public class Division
    {
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Division by zero is not allowed");
            }

            return a / b;
        }
    }
}
