using System;
using System.Linq;

namespace eulerproject
{
	public static class Factorial
	{
		public static int GetFactorial (this int n)
		{
			return Enumerable.Range (1, n)
				.Aggregate ((a, b) => a * b);
		}
	}
}

