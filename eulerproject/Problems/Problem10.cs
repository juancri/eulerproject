using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Slow]
	[Problem (10, "Summation of primes", 142913828922)]
	public class Problem10 : IProblem
	{
		public long Run ()
		{
			return Primes.Get ()
				.TakeWhile (x => x < 2000000)
				.Sum ();
		}
	}
}

