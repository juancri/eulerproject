using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (2, "Even Fibonacci numbers")]
	public class Problem2 : IProblem
	{
		public long Run ()
		{
			return GetFibonacci ()
				.TakeWhile (x => x <= 4000000)
				.Where (x => (x & 1) == 0)
				.Sum ();
		}

		private IEnumerable <int> GetFibonacci ()
		{
			var previous = 1;
			var current = 1;
			while (true)
			{
				yield return current;
				var newcurrent = current + previous;
				previous = current;
				current = newcurrent;
			}
		}
	}
}
