using System;

namespace csharp
{
    class ImmutablePeriodOfTime
    {
	public DateTime InitialDate { get; }
	public DateTime FinalDate { get; }
	
    	public ImmutablePeriodOfTime(DateTime initialDate, DateTime finalDate)
	{
	    InitialDate = initialDate;
	    FinalDate = finalDate;
	}

	public static bool CheckIfDateIsBetweenThePeriod(ImmutablePeriodOfTime period, DateTime date)
	{
	    return date.CompareTo(period.InitialDate) >= 0 && date.CompareTo(period.FinalDate) <= 0;
	}

	public static ImmutablePeriodOfTime AddDays(ImmutablePeriodOfTime period, int days)
	{
	    return new ImmutablePeriodOfTime(
	    	period.InitialDate.AddDays(days),
		period.FinalDate.AddDays(days)		
	    );
	}
    }

    class Program
    {
        static void Main(string[] args)
        {
            ImmutablePeriodOfTime period = new ImmutablePeriodOfTime(
	    	DateTime.Parse("20/08/2016"),
		DateTime.Parse("31/08/2016")
	    );

	    DateTime[] dates = new DateTime[]
	    {
	    	DateTime.Parse("18/08/2019"),
		DateTime.Parse("22/08/2016"),
		DateTime.Parse("01/09/2019")
	    };

	    foreach(DateTime date in dates)
	    {
	    	bool result = ImmutablePeriodOfTime.CheckIfDateIsBetweenThePeriod(period, date);
		Console.WriteLine(result);
	    }

	    ImmutablePeriodOfTime.AddDays(period, 30);

	    foreach(DateTime date in dates)
	    {
	    	bool result = ImmutablePeriodOfTime.CheckIfDateIsBetweenThePeriod(period, date);
		Console.WriteLine(result);
	    }
        }
    }
}
