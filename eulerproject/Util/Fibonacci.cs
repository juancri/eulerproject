using System;
using System.Collections.Generic;

namespace eulerproject
{
	public static class Fibonacci
	{
		public static IEnumerable <int> Get ()
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

