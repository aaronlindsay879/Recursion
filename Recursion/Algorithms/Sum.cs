﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public static partial class Algorithms
    {
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
