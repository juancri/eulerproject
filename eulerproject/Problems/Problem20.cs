using System;
using System.Linq;

namespace eulerproject
{
	[Problem (20, "Factorial digit sum", 648)]
	public class Problem20 : IProblem
	{
		public long Run ()
		{
			return BigFactorial.Get (100)
				.ToString ()
				.Select (c => int.Parse (c.ToString ()))
				.Sum ();
		}
	}
}
