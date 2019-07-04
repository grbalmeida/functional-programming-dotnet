using System;

namespace csharp
{
    static class NestedFunctions
    {
        public static void PrintIfNumberIsEvenOrOdd(int number)
        {
            Func<bool> verifyIfNumberIsEven = () => number % 2 == 0;

            Action printEvenNumber =
                () => Console.WriteLine(string.Format("The number {0} is even", number));

            Action printOddNumber =
                () => Console.WriteLine(string.Format("The number {0} is odd", number));

            if(verifyIfNumberIsEven())
                printEvenNumber();
            else
                printOddNumber();
        }
    }
}