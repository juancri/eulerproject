using System;
using System.Collections.Generic;

namespace eulerproject
{
	public static class Digits
	{
		public static IEnumerable <int> GetDigits (this int n)
		{
			while (n > 0)
			{
				yield return n % 10;
				n = n / 10;
			}
		}
	}
}

