using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (32, "Pandigital products", 45228)]
	public class Problem32 : IProblem
	{
		private static readonly int [] nineDigits = new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

		public long Run ()
		{
			var query =
				from n in Enumerable.Range (1, 10000)
				let digits = n.GetDigits ().ToList ()
				where n.GetFactorPairs ().Any (fp => CheckDigits (digits, fp))
				select n;

			return query.Sum ();
		}

		private static bool CheckDigits (IList <int> digits, Tuple <int, int> factorsPair)
		{
			var allDigits = digits
				.Concat (factorsPair.Item1.GetDigits ())
				.Concat (factorsPair.Item2.GetDigits ())
				.ToList ();
			
			if (allDigits.Count != 9)
				return false;
			
			return nineDigits.SequenceEqual (
				allDigits.OrderBy (d => d));
		}
	}
}

