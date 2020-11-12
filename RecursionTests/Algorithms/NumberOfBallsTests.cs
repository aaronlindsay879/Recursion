using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recursion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion.Tests
{
    [TestClass()]
    public class NumberOfBallsTests
    {
        [TestMethod]
        public void NumberOfBallsTriangleTest()
        {
            for (int i = 1; i < 100; i++)
                Assert.AreEqual(Algorithms.Sum(i), Algorithms.NoOfBallsInTriangle(i));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-14)]
        public void NumberOfBallsTriangleTestError(int n)
        {
            Assert.ThrowsException<ArgumentException>(() => Algorithms.NoOfBallsInTriangle(n));
        }

        [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(2, 4)]
        [DataRow(3, 10)]
        [DataRow(4, 20)]
        [DataRow(10, 220)]
        [DataRow(20, 1540)]
        public void NumberOfBallsPyramidTest(int n, int expected)
        {
            int pyramid = Algorithms.NoOfBallsInPyramid(n);

            Assert.AreEqual(expected, pyramid);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-14)]
        public void NumberOfBallsPyramidTestError(int n)
        {
            Assert.ThrowsException<ArgumentException>(() => Algorithms.NoOfBallsInPyramid(n));
        }
    }
}