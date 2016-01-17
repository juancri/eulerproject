using System;
using System.Linq;

namespace eulerproject
{
	[Problem (17, "Number letter counts", 1)]
	public class Problem17 : IProblem
	{
		public long Run ()
		{
			Console.WriteLine (1000.ToWords ());
			return Enumerable.Range (1, 1000)
				.Select (n => n.ToWords ())
				.Select (w => w.Length)
				.Sum ();
		}
	}
}

