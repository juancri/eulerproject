using System.Linq;

namespace eulerproject
{
	[Problem (7, "10001st prime", 104743)]
	public class Problem7 : IProblem
	{
		public long Run ()
		{
			return Primes.Get ()
				.Skip (10000)
				.First ();
		}
	}
}

