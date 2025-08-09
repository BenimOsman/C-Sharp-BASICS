using System;

namespace BASIC
{
    internal class Calci
    {
        public class Calculator() { }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b) 
        { 
            return a * b; 
        }

        public int Divide(int a, int b) 
        { 
            if (b == 0)
            {
                throw new DivideByZeroException("Can't Divide by Zero.");
            }
            return a / b; 
        }
    }
}