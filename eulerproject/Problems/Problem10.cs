using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (10, "Summation of primes")]
	public class Problem10 : IProblem
	{
		public long Run ()
		{
			return Primes.Get ()
				.TakeWhile (x => x < 2000000)
				.Select (x => (long) x)
				.Sum ();
		}
	}
}

