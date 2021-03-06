﻿using System;
using System.Collections.Generic;

namespace eulerproject
{
	public static class Factors
	{
		public static IEnumerable <int> GetFactors (this int n)
		{
			var a = 0;
			var b = 0;
			var sqrt = Math.Sqrt (n);
			do {
				a++;
				if (a > sqrt)
					yield break;
				if (n % a == 0) {
					yield return a;
					b = n / a;
					if (a != b)
						yield return b;
					b--;
				}
			} while (a < b);
		}

		public static IEnumerable <Tuple <int, int>> GetFactorPairs (this int n)
		{
			var a = 0;
			var b = 0;
			var sqrt = Math.Sqrt (n);
			do {
				a++;
				if (a > sqrt)
					yield break;
				if (n % a == 0) {
					b = n / a;
					yield return new Tuple <int, int> (a, b);
					b--;
				}
			} while (a < b);
		}
	}
}

