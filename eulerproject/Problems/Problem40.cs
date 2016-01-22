using System;
using System.Linq;

namespace eulerproject
{
	[Problem (40, "Champernowne's constant", 210)]
	public class Problem40 : IProblem
	{
		public long Run ()
		{
			var digits = Naturals.Get ()
				.SelectMany (n => n.GetDigits ().Reverse ())
				.Take (1000000)
				.ToList ();

			return digits [0] * digits [9] * digits [99] *
				digits [999] * digits [9999] * digits [99999] *
				digits [999999];
		}
	}
}

