using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (4, "Largest palindrome product", 906609)]
	public class Problem4 : IProblem
	{
		public long Run ()
		{
			return GetProducts (100, 999)
				.Where (x => IsPalindrome (x))
				.Max ();
		}

		private static IEnumerable <int> GetProducts (int min, int max)
		{
			return
				from x1 in Enumerable.Range (min, max - min + 1)
				from x2 in Enumerable.Range (min, x1 - min + 1)
				select x1 * x2;
		}

		private static bool IsPalindrome (int n)
		{
			var digits = GetDigits (n).ToList ();
			int a = 0;
			int b = digits.Count - 1;
			while (a < b)
			{
				if (digits [a] != digits [b])
					return false;
				a++;
				b--;
			}

			return true;
		}

		private static IEnumerable <int> GetDigits (int n)
		{
			while (n > 0)
			{
				yield return n % 10;
				n = n / 10;
			}
		}
	}
}

