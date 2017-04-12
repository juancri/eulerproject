using System.Linq;

namespace eulerproject
{
	[Problem (3, "Largest prime factor", 6857)]
	public class Problem3 : IProblem
	{
		public long Run ()
		{
			return PrimeFactors
				.Get (600851475143)
				.Last ();
		}
	}
}

