using System.Linq;

namespace eulerproject
{
	[Problem (10, "Summation of primes", 142913828922)]
	public class Problem10 : IProblem
	{
		public long Run ()
		{
			return EratosthenesPrimes.Get (2000000 - 1)
				.Sum ();
		}
	}
}

