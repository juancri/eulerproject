using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (37, "Truncatable primes", 748317)]
	public class Problem37 : IProblem
	{
		public long Run ()
		{
			var cache = new List <int> ();
			var found = new List <int> ();

			foreach (var longPrime in Primes.Get ())
			{
				var prime = (int)longPrime;
				cache.Add (prime);
				if (prime < 10)
					continue;

				var digits = prime.GetDigits ().Reverse ();
				if (digits.Contains (0))
					continue;
				if (!CheckPrimeDigits (cache, digits, true))
					continue;
				if (!CheckPrimeDigits (cache, digits, false))
					continue;

				Console.WriteLine ("found {0}", prime);
				found.Add (prime);
				if (found.Count == 11)
					return found.Sum ();
			}

			throw new Exception ("Should not reach here");
		}

		private static bool CheckPrimeDigits (List <int> cache, IEnumerable <int> digits, bool direction)
		{
			var localDigits = digits.ToList ();
			while (localDigits.Count > 1)
			{
				if (direction)
					localDigits.RemoveAt (localDigits.Count - 1);
				else
					localDigits.RemoveAt (0);
				
				var num = localDigits.Aggregate ((a, b) => a * 10 + b);
				if (!cache.Contains (num))
					return false;
				//Console.WriteLine (num);
			}
			return true;
		}
	}
}

