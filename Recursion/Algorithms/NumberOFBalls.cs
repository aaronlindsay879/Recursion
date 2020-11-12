using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public static partial class Algorithms
    {
        /// <summary>
        /// This method simply leads to summing from 1 to sideLength
        /// You remove one side from the triangle (n) and then add that to the area of the remaining triangle, which is 1 sideLength shorter
        /// </summary>
        /// <param name="sideLength">Length of one side of triangle</param>
        /// <returns>Number of balls in triangle</returns>
        public static int NoOfBallsInTriangle(int sideLength) => Sum(sideLength);

        /// <summary>
        /// Calculates the number of balls in a pyramid
        /// Works by removing largest face from the pyramid, using the algorithm above, and then calculating remaining number of balls recursively
        /// </summary>
        /// <param name="sideLength">Length of one side of pyramid</param>
        /// <returns>Number of balls in pyramid</returns>
        public static int NoOfBallsInPyramid(int sideLength)
        {
            if (sideLength < 1)
                throw new ArgumentException("Number cannot be below 1");

            //base case
            if (sideLength == 1)
                return 1;

            //remove largest face from pyramid - triangle with length sideLength
            //then calculate the area of remaining pyramid
            return NoOfBallsInTriangle(sideLength) + NoOfBallsInPyramid(sideLength - 1);
        }
    }
}
