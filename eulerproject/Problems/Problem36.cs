using System;
using System.Linq;

namespace eulerproject
{
	[Problem (36, "Double-base palindromes", 872187)]
	public class Problem36 : IProblem
	{
		public long Run ()
		{
			return Enumerable.Range (1, 999999)
				.Where (n => n.IsPalindrome () && Convert.ToString (n, 2).IsPalindrome ())
				.Sum ();
		}
	}
}

