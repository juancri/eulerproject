using System;
using System.Collections.Generic;

namespace eulerproject
{
	public static class Factors
	{
		public static IEnumerable <int> GetFactors (this int n)
		{
			var a = 0;
			var b = 0;
			do {
				a++;
				if (n % a == 0) {
					yield return a;
					b = n / a;
					if (a != b)
						yield return b;
					b--;
				}
			} while (a < b);
		}
	}
}

