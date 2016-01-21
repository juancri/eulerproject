using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	public static class Cyrcles
	{
		public static IEnumerable <int> GetCyrcles (this int n)
		{
			var digits = n.GetDigits ().Reverse ().ToList ();
			return Enumerable.Range (1, digits.Count - 1)
				.Select (index => digits
					.Skip (index)
					.Concat (digits.Take (index))
					.Aggregate ((a, b) => (a * 10) + b));
		}
	}
}

