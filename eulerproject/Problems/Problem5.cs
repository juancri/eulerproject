﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Slow]
	[Problem (5, "Smallest multiple", 232792560)]
	public class Problem5 : IProblem
	{
		public long Run ()
		{
			var factors = SiplifyFactors (Enumerable.Range (1, 20));
			return Naturals.Get ()
				.Where (x => IsEvenlyDivisible (x, factors))
				.First ();
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

