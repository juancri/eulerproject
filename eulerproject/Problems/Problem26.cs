using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (26, "Reciprocal cycles", 983)]
	public class Problem26 : IProblem
	{
		public long Run ()
		{
			return Enumerable.Range (2, 998)
				.Select (n => new { number = n, cycle = GetCycle (n) })
				.Where (x => x.cycle != null)
				.OrderByDescending (x => x.cycle.Count())
				.First ()
				.number;
		}

		private static IList <int> GetCycle (int n)
		{
			var remainders = new SortedDictionary <int, int> ();
			var baseDivision = (int) Math.Pow (10, Math.Floor (Math.Log10 (n)) + 1);
			var newBase = baseDivision;
			while (true)
			{
				var newDecimal = newBase / n;
				var remainder = newBase % n;
				if (remainder == 0)
					return null;

				if (remainders.ContainsKey (remainder))
					return remainders.Values
						.Skip (remainders.Keys.ToList ().IndexOf (remainder))
						.ToList ();

				remainders.Add (remainder, newDecimal);
				newBase = baseDivision * remainder;
			}
		}
	}
}

