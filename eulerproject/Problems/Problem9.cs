using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (9, "Special Pythagorean triplet")]
	public class Problem9 : IProblem
	{
		public long Run ()
		{
			return GetPitagoreanTriplets ()
				.Where (pt => pt.A + pt.B + pt.C == 1000)
				.Select (pt => pt.A * pt.B * pt.C)
				.First ();
		}

		private static IEnumerable <PythagoreanTriplet> GetPitagoreanTriplets ()
		{
			return
				from b in Naturals.Get (2)
				from a in Enumerable.Range (1, b - 1)
				let powA = Math.Pow (a, 2)
				let powB = Math.Pow (b, 2)
				let powC = powA + powB
				let c = Math.Sqrt (powC)
				where c % 1 == 0
				select new PythagoreanTriplet { A = a, B = b, C = (int) c };
		}

		class PythagoreanTriplet
		{
			public int A { get; set; }
			public int B { get; set; }
			public int C { get; set; }
		}
	}
}

