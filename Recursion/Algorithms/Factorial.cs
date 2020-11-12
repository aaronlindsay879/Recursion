using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public static partial class Algorithms
    {
        /// <summary>
        /// Calculates the factorial of a number recursively <br/>
        /// Works by multiplying <paramref name="n"/> by the factorial of the number 1 less than it
        /// </summary>
        /// <param name="n">Int to find factorial of</param>
        /// <returns>Factorial of <paramref name="n"/></returns>
        public static int Factorial(int n)
        {
            if (n < 1)
                throw new ArgumentException("Number cannot be below 1");

            //base case
            if (n == 1)
                return 1;

            return n * Factorial(n - 1);
        }
    }
}
