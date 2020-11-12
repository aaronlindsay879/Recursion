using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recursion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion.Tests
{
    [TestClass()]
    public class FactorialTests
    {
        [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(5, 120)]
        [DataRow(10, 3628800)]
        public void FactorialTest(int n, int expected)
        {
            int factorial = Algorithms.Factorial(n);

            Assert.AreEqual(expected, factorial);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-14)]
        public void FactorialTestError(int n)
        {
            Assert.ThrowsException<ArgumentException>(() => Algorithms.Factorial(n));
        }
    }
}