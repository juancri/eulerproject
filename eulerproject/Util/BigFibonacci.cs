using System;
using System.Collections.Generic;
using System.Numerics;

namespace eulerproject
{
	public static class BigFibonacci
	{
		public static IEnumerable <BigInteger> Get ()
		{
			var previous = new BigInteger (1);
			var current = new BigInteger (1);
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

