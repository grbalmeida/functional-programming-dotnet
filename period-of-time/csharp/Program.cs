using System;

namespace csharp
{
	class Statement
	{
		void ExampleUseOfStatement(int number)
		{
			bool evenNumber = number % 2 == 0;
			int result = evenNumber ? 2 : 0;

			Console.WriteLine(result);
			Console.ReadKey();
		}
	}

	class PeriodOfTime
    	{
    		public DateTime InitialDate { get; set; }
			public DateTime FinalDate { get; set; }

			public bool CheckIfDateIsBetweenThePeriod(DateTime date)
	{
	    	return date.CompareTo(InitialDate) >= 0 && date.CompareTo(FinalDate) <= 0;
		}
    }

    class Program
    {
        static void Main(string[] args)
        {
            PeriodOfTime period = new PeriodOfTime();

	    	period.InitialDate = DateTime.Parse("20/08/2016");
	    	period.FinalDate = DateTime.Parse("31/08/2016");

	    	DateTime[] dates = new DateTime[]
	    	{
	    		DateTime.Parse("18/08/2016"),
				DateTime.Parse("22/08/2016"),
				DateTime.Parse("01/09/2016")
	    	};

	    	foreach(DateTime date in dates)
	    	{
	    		bool result = period.CheckIfDateIsBetweenThePeriod(date);
				Console.WriteLine(result);
	    	}

	    	period.FinalDate = DateTime.MaxValue;
	    	Console.WriteLine("After MaxValue");

	    	foreach(DateTime date in dates)
	    	{
	    		bool result = period.CheckIfDateIsBetweenThePeriod(date);
				Console.WriteLine(result);
	    	}

	    	Console.ReadKey();
        }
    }
}
