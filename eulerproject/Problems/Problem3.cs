using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (3, "Largest prime factor", 6857)]
	public class Problem3 : IProblem
	{
		public long Run ()
		{
			return GetPrimeFactors (600851475143).Last ();
		}

		private IEnumerable <int> GetPrimeFactors (long n)
		{
			foreach (var p in Primes.Get ())
			{
				if (n % p != 0)
					continue;

				yield return p;
				n = n / p;
				if (n == 1)
					break;
			}
		}
	}
}

