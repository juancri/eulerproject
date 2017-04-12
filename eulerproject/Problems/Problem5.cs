using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (5, "Smallest multiple", 232792560)]
	public class Problem5 : IProblem
	{
		public long Run ()
		{
			var max = 20;
			var factors = new List <int> ();
			var products = new List <int> ();
			foreach (var n in Enumerable.Range (1, max))
			{
				if (products.Contains (n))
					continue;

				var newFactor = products
					.OrderByDescending (p => p)
					.Where (p => n % p == 0)
					.Select (p => n / p)
					.FirstOrDefault ();
				if (newFactor == 0)
					newFactor = n;

				products.AddRange (products.Select (p => newFactor * p).ToList ());
				products.Add (newFactor);
				factors.Add (newFactor);
			}

			return factors.Aggregate ((a, b) => a * b);
		}
	}
}

