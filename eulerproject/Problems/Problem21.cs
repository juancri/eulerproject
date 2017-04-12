using System.Linq;

namespace eulerproject
{
	[Slow]
	[Problem (21, "Amicable numbers", 31626)]
	public class Problem21 : IProblem
	{
		public long Run ()
		{
			var numbersAndFactors = Enumerable.Range (1, 10000)
				.AsParallel ()
				.Select (x => new
				{
					number = x,
					sum = x.GetFactors ()
						.Where (f => f != x)
						.Sum ()
				})
				.ToList ();

			var amicableNumbers =
				(from n1 in numbersAndFactors.AsParallel ()
				 from n2 in numbersAndFactors
				 where n1.number < n2.number
				 where n1.sum == n2.number
				 where n1.number == n2.sum
				 select new [] { n1.number, n2.number });

			return amicableNumbers
				.SelectMany (x => x)
				.Distinct ()
				.Sum ();
		}
	}
}

