using System;
using System.Linq;

namespace eulerproject
{
	[Problem (17, "Number letter counts", 21124)]
	public class Problem17 : IProblem
	{
		public long Run ()
		{
			return Enumerable.Range (1, 1000)
				.Select (n => n.ToWords ())
				.Select (w => w.Length)
				.Sum ();
		}
	}
}

