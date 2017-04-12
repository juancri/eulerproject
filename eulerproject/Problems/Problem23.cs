using System.Linq;

namespace eulerproject
{
	[Slow]
	[Problem (23, "Non-abundant sums", 4179871)]
	public class Problem23 : IProblem
	{
		public long Run ()
		{
			var max = 28123;
			var abundantNumbers = Enumerable.Range (1, max)
				.AsParallel ()
				.Where (n => n < n.GetFactors ().Where (f => f != n).Sum ())
				.ToList ();

			var sums =
				(from a1 in abundantNumbers.AsParallel ()
				from a2 in abundantNumbers
				where a1 <= a2
				let sum = a1 + a2
				where sum <= max
				select sum)
					.Distinct ()
					.ToList ();

			return Enumerable.Range (1, max)
				.Where (n => !sums.Contains (n))
				.Sum ();
		}
	}
}

