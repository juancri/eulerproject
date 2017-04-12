using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	public static class EratosthenesPrimes
	{
		public static IEnumerable <long> Get (long maximum)
		{
			var sqrt = Math.Sqrt (maximum);
			var excluded = new bool[maximum];
			var current = 1;
			while (true)
			{
				current++;
				if (current > maximum)
					break;

				if (!excluded [current - 1])
					yield return current;

				if (current > sqrt)
					continue;

				var temp = (long) Math.Pow (current, 2);
				while (true)
				{
					if (temp > maximum)
						break;
					excluded[temp - 1] = true;
					temp += current;
				}
			}
		}
	}
}
