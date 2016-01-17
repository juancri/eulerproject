using System;
using System.Linq;

namespace eulerproject
{
	public static class NumberIsPalindrome
	{
		public static bool IsPalindrome (this int n)
		{
			var digits = n.GetDigits ().ToList ();
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
	}
}

