using System;

namespace Factorial
{
    public class Fact
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine($"Factorial of {n} is {factorial(n)}");
        }
        public static int factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return (n * factorial(n - 1));
        }
    }
}