using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public static partial class Algorithms
    {
        public static int Fibonacci(int n)
        {
            if (n < 1)
                throw new ArgumentException("Number cannot be below 1");

            //base cases
            //seed values of 1, 1
            if (n == 1 || n == 2)
                return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
