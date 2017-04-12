using System.Linq;

namespace eulerproject
{
	[Problem (35, "Circular primes", 55)]
	public class Problem35 : IProblem
	{
		public long Run ()
		{
			var maximum = 1000000 - 1;
			var primes = EratosthenesPrimes.GetArray (maximum);

			return Enumerable.Range (2, maximum - 1)
				.AsParallel ()
				.Where (n => !primes [n - 1])
				.Where (p => p.GetCyrcles ().All (c => !primes [c - 1]))
				.Count ();
		}
	}
}

