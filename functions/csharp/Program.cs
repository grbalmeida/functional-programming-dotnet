using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            NestedFunctions.PrintIfNumberIsEvenOrOdd(10);
            NestedFunctions.PrintIfNumberIsEvenOrOdd(5);

            WriteFunctions.Write("Maria");
            WriteFunctions.Write("John");

            List<int> evenNumbers = new List<int>();
            IEnumerable<int> numbers = Enumerable.Range(0, 10);
            Func<int, bool> filterMethod = CheckerEvenNumber.NumberIsEven;

            IEnumerable<int> evenNumbersWithLinq = numbers.Where(filterMethod);

            foreach(int number in numbers)
            {
                if(CheckerEvenNumber.NumberIsEven(number))
                {
                    evenNumbers.Add(number);
                }
            }

            CheckerEvenNumber.GetEvenNumbersFromAList();

            List<string> names = new List<string> {
                "Gabriel", "John", "Jose", "Maria"
            };

            List<int> myNumbers = new List<int> {
                10, 20, 30, 40
            };

            HigherOrderFunctions.PrintNames(names);
            HigherOrderFunctions.DoublePrintingNumbers(myNumbers);

            Action<int> multiplyBy5AndThenPrint = HigherOrderFunctions.MultiplyAndPrintNumbers(5);
            Action<int> multiplyBy3AndThenPrint = HigherOrderFunctions.MultiplyAndPrintNumbers(3);

            int numberToBeMultiplied = 10;

            multiplyBy5AndThenPrint(numberToBeMultiplied);
            multiplyBy3AndThenPrint(numberToBeMultiplied);
        }
    }
}
