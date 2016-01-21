using System;
using System.Linq;

namespace eulerproject
{
	public static class Factorial
	{
		public static int GetFactorial (this int n)
		{
			if (n == 0)
				return 1;
			
			return Enumerable.Range (1, n)
				.Aggregate ((a, b) => a * b);
		}
	}
}

