using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public static partial class Algorithms
    {
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
