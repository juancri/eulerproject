using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	public class PythagoreanTriplet
	{
		public int A { get; set; }
		public int B { get; set; }
		public int C { get; set; }

		public PythagoreanTriplet ()
		{
		}

		public static IEnumerable <PythagoreanTriplet> GetAll ()
		{
			return
				from b in Naturals.Get (2)
				from a in Enumerable.Range (1, b - 1)
				let powA = Math.Pow (a, 2)
				let powB = Math.Pow (b, 2)
				let powC = powA + powB
				let c = Math.Sqrt (powC)
				where c % 1 == 0
				select new PythagoreanTriplet { A = a, B = b, C = (int)c };
		}
	}
}

