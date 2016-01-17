using System;
using System.Linq;

namespace eulerproject
{
	[Problem (19, "Counting Sundays", 171)]
	public class Problem19 : IProblem
	{
		public long Run ()
		{
			return (from year in Enumerable.Range (1901, 100)
			        from month in Enumerable.Range (1, 12)
			        let date = new DateTime (year, month, 1)
					where date.DayOfWeek == DayOfWeek.Sunday
			        select 1).Count ();
		}
	}
}

