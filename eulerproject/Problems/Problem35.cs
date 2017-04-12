using System.Linq;

namespace eulerproject
{
	[Slow]
	[Problem (35, "Circular primes", 55)]
	public class Problem35 : IProblem
	{
		public long Run ()
		{
			var primes = Primes.Get ()
				.TakeWhile (p => p < 1000000)
				.Select (p => (int) p)
				.ToList ();

			return primes
				.AsParallel ()
				.Where (p => p.GetCyrcles ().All (c => primes.Contains (c)))
				.Count ();
		}
	}
}

