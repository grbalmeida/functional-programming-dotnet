using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Factorial(2));
            Console.WriteLine(Math.Factorial(3));
            Console.WriteLine(Math.Factorial(4));

            Console.WriteLine(Math.RecursiveFactorial(2));
            Console.WriteLine(Math.RecursiveFactorial(3));
            Console.WriteLine(Math.RecursiveFactorial(4));
        }
    }
}
