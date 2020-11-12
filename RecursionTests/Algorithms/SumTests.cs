using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recursion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion.Tests
{
    [TestClass()]
    public class SumTests
    {
        [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(5, 15)]
        [DataRow(10, 55)]
        public void SumTest(int n, int expected)
        {
            int sum = Algorithms.Sum(n);

            Assert.AreEqual(expected, sum);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-14)]
        public void SumTestError(int n)
        {
            Assert.ThrowsException<ArgumentException>(() => Algorithms.Sum(n));
        }
    }
}