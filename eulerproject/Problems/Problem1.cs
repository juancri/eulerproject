using System;
using System.Linq;

namespace eulerproject
{
	[Problem (1, "Multiples of 3 and 5")]
	public class Problem1 : IProblem
	{
		public long Run ()
		{
			return Enumerable.Range (1, 1000)
				.Where (x => x % 3 == 0 || x % 5 == 0)
				.Sum ();
		}
	}
}

