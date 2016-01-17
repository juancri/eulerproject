using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	public static class Primes
	{
		public static IEnumerable <int> Get ()
		{
			var temp = new List <int> ();
			var current = 1;
			while (true)
			{
				current++;
				var sqrt = Math.Sqrt (current);
				if (temp
					.TakeWhile (x => x <= sqrt)
					.Any (x => current % x == 0))
					continue;

				temp.Add (current);
				yield return current;
			}
		}
	}
}

