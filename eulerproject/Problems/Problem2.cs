using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (2, "Even Fibonacci numbers", 4613732)]
	public class Problem2 : IProblem
	{
		public long Run ()
		{
			return Fibonacci.Get ()
				.TakeWhile (x => x <= 4000000)
				.Where (x => (x & 1) == 0)
				.Sum ();
		}
	}
}
