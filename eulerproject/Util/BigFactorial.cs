using System;
using System.Linq;
using System.Numerics;

namespace eulerproject
{
	public static class BigFactorial
	{
		public static BigInteger Get (int n)
		{
			return Enumerable.Range (1, n)
				.Select (x => new BigInteger (x))
				.Aggregate (BigInteger.Multiply);
		}
	}
}

