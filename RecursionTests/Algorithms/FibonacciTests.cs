using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recursion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion.Tests
{
    [TestClass()]
    public class FibonacciTests
    {
        [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(2, 1)]
        [DataRow(3, 2)]
        [DataRow(4, 3)]
        [DataRow(20, 6765)]
        [DataRow(40, 102334155)]
        public void FibonacciTest(int n, int expected)
        {
            int fibonacci = Algorithms.Fibonacci(n);

            Assert.AreEqual(expected, fibonacci);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-14)]
        public void FibonacciTestError(int n)
        {
            Assert.ThrowsException<ArgumentException>(() => Algorithms.Fibonacci(n));
        }
    }
}