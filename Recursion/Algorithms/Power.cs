using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public static partial class Algorithms
    {
        /// <summary>
        /// Calculates <paramref name="y"/>^<paramref name="n"/> <br/>
        /// Works by multiplying <paramref name="y"/> (the base) by <paramref name="y"/>^(<paramref name="n"/> - 1)
        /// </summary>
        /// <param name="y">Base</param>
        /// <param name="n">Exponent</param>
        /// <returns><paramref name="y"/>^<paramref name="n"/></returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="n"/> below 1</exception>
        public static int Power(int y, int n)
        {
            if (n < 1)
                throw new ArgumentException("Exponent cannot be below 1");

            //base case
            if (n == 1)
                return y;

            return y * Power(y, n - 1);
        }
    }
}
