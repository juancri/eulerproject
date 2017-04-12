using System.Linq;

namespace eulerproject
{
	[Problem (4, "Largest palindrome product", 906609)]
	public class Problem4 : IProblem
	{
		public long Run ()
		{
			return Products.Get (100, 999)
				.Where (x => x.IsPalindrome ())
				.Max ();
		}
	}
}

