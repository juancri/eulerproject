using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (38, "Pandigital multiples", 932718654)]
	public class Problem38 : IProblem
	{
		public long Run ()
		{
			return Enumerable.Range (1, 100000)
				.Select (n => GetPandigits (n))
				.Where (x => x > 0)
				.Max ();
		}

		private static long GetPandigits (int n)
		{
			var digits = new List <int> ();
			var multiplicator = 1;
			while (true)
			{
				digits.AddRange ((n * multiplicator).GetDigits ().Reverse ());
				if (digits.Count >= 9)
					break;
				multiplicator++;
			}

			if (digits.Count == 9 &&
				digits.Distinct ().Count() == 9 &&
				digits.All (d => d > 0))
				return digits
					.Select (d => (long)d)
					.Aggregate ((a, b) => a * 10 + b);

			return 0;
		}
	}
}

