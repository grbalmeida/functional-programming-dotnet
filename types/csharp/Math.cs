namespace csharp
{
    class Math
    {
        public static int Factorial(int numberToCalculateFactorial)
        {
            int accumulator = numberToCalculateFactorial;
            
            for(int number = numberToCalculateFactorial - 1; number >= 1; number--)
            {
                accumulator = accumulator * number;
            }

            return accumulator;
        }

        public static int RecursiveFactorial(int number)
        {
            return number == 0 || number == 1 ? 1
                : number == 2 ? 2
                : number * RecursiveFactorial(number - 1);
        }
    }
}