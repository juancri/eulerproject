using System;
using System.Linq;

namespace eulerproject
{
	[Problem (30, "Digit fifth powers", 443839)]
	public class Problem30 : IProblem
	{
		public long Run ()
		{
			return
				Enumerable.Range (1000, 999000)
					.Where (n => n ==
						n.GetDigits ().Select (d => Math.Pow (d, 5)).Sum ())
					.Sum ();
		}
	}
}

