using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{

    class Calculator {
	public int RaiseNumberSquared(int number) {
	    return number * number;
	}

	public int SquareSumOfTheNumbersUpToTen() {
	    int sum = 0;

	    for(int number = 1; number <= 10; number++) {
	        sum += RaiseNumberSquared(number);
	    }

	    return sum;
	}

	public int SquareSumOfTheNumbersUpToTenWithEnumerable() {
	    return Enumerable.Range(1, 10)
		              .Select(RaiseNumberSquared)
			      .Sum();
	}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
	    Console.WriteLine(calculator.SquareSumOfTheNumbersUpToTen());
	    Console.WriteLine(calculator.SquareSumOfTheNumbersUpToTenWithEnumerable());
	    Console.ReadKey();
        }
    }
}
