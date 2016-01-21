using System;
using System.Linq;

namespace eulerproject
{
	[Problem (29, "Distinct powers", 9183)]
	public class Problem29 : IProblem
	{
		public long Run ()
		{
			var seq =
				from a in Enumerable.Range (2, 99)
				from b in Enumerable.Range (2, 99)
				select Math.Pow (a, b);

			return seq.Distinct ().Count ();
		}
	}
}

