﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (3, "Largest prime factor")]
	public class Problem3 : IProblem
	{
		public int Run ()
		{
			return GetPrimeFactors (600851475143).Last ();
		}

		private IEnumerable <int> GetPrimeFactors (long n)
		{
			foreach (var p in GetPrimes ())
			{
				if (n % p != 0)
					continue;

				yield return p;
				n = n / p;
				if (n == 1)
					break;
			}
		}

		private IEnumerable <int> GetPrimes ()
		{
			var temp = new List <int> ();
			var current = 1;
			while (true)
			{
				current++;
				if (temp.Any (x => current % x == 0))
					continue;

				temp.Add (current);
				yield return current;
			}
		}
	}
}
