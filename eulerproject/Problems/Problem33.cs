using System;
using System.Linq;

namespace eulerproject
{
	[Problem (33, "Digit cancelling fractions", 100)]
	public class Problem33 : IProblem
	{
		public long Run ()
		{
			var fractions =
				from denominator in Enumerable.Range (1, 99)
				from numerator in Enumerable.Range (1, 99)
				where numerator > 10
				where denominator > 10
				where numerator < denominator
				where numerator % 10 != 0
				where denominator % 10 != 0
				let dnumerator = (decimal)numerator
				let ddenominator = (decimal)denominator
				let result = dnumerator / ddenominator
				where
					(numerator % 10 == denominator / 10 &&
					(numerator / 10) / (ddenominator % 10) == result) ||
					(numerator / 10 == denominator % 10 &&
					(dnumerator % 10) / (denominator / 10) == result)
				select new Tuple <int, int> (numerator, denominator);

			var total = fractions.Aggregate ((a, b) =>
				new Tuple <int, int> (
					a.Item1 * b.Item1,
					a.Item2 * b.Item2));

			while (true)
			{
				var factors1 = total.Item1.GetFactors ().Where (f => f > 1).ToList ();
				var factors2 = total.Item2.GetFactors ().Where (f => f > 1).ToList ();
				var commonList = factors1.Intersect (factors2).ToList ();
				if (commonList.Count == 0)
					break;
				var common = commonList.Max ();
				total = new Tuple <int, int> (
					total.Item1 / common,
					total.Item2 / common);
			}

			return total.Item2;
		}
	}
}

