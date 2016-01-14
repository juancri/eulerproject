using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (12, "Highly divisible triangular number")]
	public class Problem12 : IProblem
	{
		public long Run ()
		{
			return GetTriangleNumbers ()
				.Where (x => GetFactors (x).Count() > 500)
				.First ();
		}

		private static IEnumerable <int> GetTriangleNumbers ()
		{
			int current = 0;
			int n = 0;
			while (true)
			{
				n++;
				yield return (current += n);
			}
		}

		private static IEnumerable <int> GetFactors (int n)
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

