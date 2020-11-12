using System;
using System.Threading;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Example sum: Sum(10) = {Algorithms.Sum(10)}");
            Console.WriteLine($"Example factorial: Factorial(10) = {Algorithms.Factorial(10)}");
            Console.WriteLine($"Example power: Power(2, 10) = {Algorithms.Power(2, 10)}");
            Console.WriteLine($"Example fibonacci: Fibonacci(4) = {Algorithms.Fibonacci(4)}");

            Console.WriteLine($"\nExample number of balls in triangle: NoOfBallsInTriangle(4) = {Algorithms.NoOfBallsInTriangle(4)}");
            Console.WriteLine($"Example number of balls in pyramid: NoOfBallsInPyramid(4) = {Algorithms.NoOfBallsInPyramid(4)}\n");


            Console.WriteLine("Causing stack overflow with fibonacci in 5 seconds.\n");
            Thread.Sleep(5000);

            Console.WriteLine(Algorithms.Fibonacci(1000000));
        }
    }
}
