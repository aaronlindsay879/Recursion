using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recursion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion.Tests
{
    [TestClass()]
    public class PowerTests
    {
        [DataTestMethod]
        [DataRow(1, 2, 1)]
        [DataRow(2, 3, 8)]
        [DataRow(7, 8, 5764801)]
        public void PowerTest(int y, int n, int expected)
        {
            int power = Algorithms.Power(y, n);

            Assert.AreEqual(expected, power);
        }

        [DataTestMethod]
        [DataRow(12, 0)]
        [DataRow(4, -4231)]
        public void PowerTestError(int y, int n)
        {
            Assert.ThrowsException<ArgumentException>(() => Algorithms.Power(y, n));
        }
    }
}