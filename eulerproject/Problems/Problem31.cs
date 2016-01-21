using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Slow]
	[Problem (31, "Coin sums", 73682)]
	public class Problem31 : IProblem
	{
		private static readonly int[] currencies = new [] { 1, 2, 5, 10, 20, 50, 100, 200 };

		public long Run ()
		{
			var permutations = GetPermutations (200);
			return permutations.Count ();
		}

		private static IEnumerable <IEnumerable <int>> GetPermutations (int amount)
		{
			return GetPermutations (amount, amount + 1);
		}

		private static IEnumerable <IEnumerable <int>> GetPermutations (int amount, int max)
		{
			if (amount == 0)
				yield return new int[0];
			
			if (amount == 1)
			{
				yield return new [] { 1 };
				yield break;
			}
			
			var baseNumbers = currencies
				.Where (c => c <= amount)
				.Where (c => c <= max)
				.OrderByDescending (c => c);
			
			foreach (var baseNumber in baseNumbers)
			{
				var baseEnumeration = new [] { baseNumber };
				foreach (var subpermutation in GetPermutations (amount - baseNumber, baseNumber))
					yield return baseEnumeration.Concat (subpermutation);
			}
		}
	}

	class LambdaEqualityComparer <T> : IEqualityComparer <T>
	{
		private Func<T, T, bool> comparer;

		public LambdaEqualityComparer (Func<T, T, bool> comparer)
		{
			this.comparer = comparer;
		}

		public bool Equals(T o1, T o2)
		{
			return this.comparer (o1, o2);
		}

		public int GetHashCode(T o)
		{
			return o.GetHashCode ();
		}
	}
}

