using System;

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
        }
    }
}
