using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (5, "Smallest multiple")]
	public class Problem5 : IProblem
	{
		public long Run ()
		{
			var factors = SiplifyFactors (Enumerable.Range (1, 20));
			return GetNaturalNumbers ()
				.Where (x => IsEvenlyDivisible (x, factors))
				.First ();
		}

		private static IEnumerable <int> GetNaturalNumbers ()
		{
			int n = 1;
			while (true)
			{
				yield return n;
				n++;
			}
		}

		private static bool IsEvenlyDivisible (int n, IEnumerable <int> factors)
		{
			return factors.All (x => n % x == 0);
		}

		private static IList <int> SiplifyFactors (IEnumerable <int> factors)
		{
			var factors2 = factors.ToList ();
			return factors2
				.Where (x => !factors2.Any (x2 => x != x2 && x2 % x == 0))
				.OrderByDescending (x => x)
				.ToList ();
		}
	}
}

