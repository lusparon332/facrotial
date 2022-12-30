using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine($"Factorial of {n} is {factorial(n)}");
        }
        static int factorial(int n)
        {
            if (n == 0 || n == 1)
                return n;
            return (n * factorial(n - 1));
        }
    }
}