using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    static class HigherOrderFunctions
    {
        public static void PerformActionOnElements<ElementType>(List<ElementType> list, Action<ElementType> action)
        {
            list.ForEach(action);
        }

        public static void PrintNames(List<string> names)
        {
            PerformActionOnElements(names, Console.WriteLine);
        }

        public static void DoublePrintingNumbers(List<int> numbers)
        {
            PerformActionOnElements(numbers,
                number => Console.WriteLine(number * 2));
        }

        public static Action<int> MultiplyAndPrintNumbers(int multiplier)
        {
            return (number) => Console.WriteLine(number * multiplier);
        }

        public static void PrintNumbers(List<int> numbers, int multiplier)
        {
            Action<int> multiply = MultiplyAndPrintNumbers(multiplier);
            PerformActionOnElements(numbers,
                number => multiply(number));
        }
    }

    static class CheckerEvenNumber
    {
        public static bool NumberIsEven(int number)
        {
            return number % 2 == 0;
        }

        public static void GetEvenNumbersFromAList()
        {
            Func<int, bool> methodToFilterViaLambda =
                number => number % 2 == 0;
            IEnumerable<int> evenNumbers;
            IEnumerable<int> numbers = Enumerable.Range(0, 10);
            evenNumbers = numbers.Where(methodToFilterViaLambda);

            foreach(int evenNumber in evenNumbers)
            {
                Console.WriteLine(evenNumber);
            }
        }
    }
}
