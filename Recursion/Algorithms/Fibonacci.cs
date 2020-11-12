using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public static partial class Algorithms
    {
        /// <summary>
        /// Calculates the fibonnaci number at position <paramref name="n"/> <br/>
        /// Works by summing the fibonnaci numbers one and two below <paramref name="n"/>, using base cases of 1,1 and 2,1
        /// </summary>
        /// <param name="n">Position of fibonacci number to find</param>
        /// <returns>Fibonnaci number at <paramref name="n"/></returns>
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
