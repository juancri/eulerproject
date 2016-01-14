using System;
using System.Linq;

namespace eulerproject
{
	[Problem (7, "10001st prime")]
	public class Problem7 : IProblem
	{
		public long Run ()
		{
			return Primes.Get ()
				.Skip (10000)
				.First ();
		}
	}
}

