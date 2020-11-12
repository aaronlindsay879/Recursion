using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public static partial class Algorithms
    {
        /// <summary>
        /// Finds 1 + 2 + ... + <paramref name="n"/> <br/>
        /// Works by adding <paramref name="n"/> to the sum of <paramref name="n"/> - 1
        /// </summary>
        /// <param name="n">Upper limit of summation</param>
        /// <returns>1 + 2 + ... + <paramref name="n"/></returns>
        public static int Sum(int n)
        {
            if (n < 1)
                throw new ArgumentException("Number cannot be below 1");

            //base case
            if (n == 1)
                return 1;

            return n + Sum(n - 1);
        }
    }
}
