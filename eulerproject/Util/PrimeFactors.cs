using System;
using System.Collections.Generic;

namespace eulerproject
{
	public static class PrimeFactors
	{
		public static IEnumerable <long> Get (long n)
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

