using System.Linq;
using System.Collections.Generic;

namespace eulerproject
{
	[Problem (24, "Lexicographic permutations", 2783915460)]
	public class Problem24 : IProblem
	{
		public long Run ()
		{
			return GetPermutation (new [] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 999999)
				.Select (x => (long) x)
				.Aggregate ((a, b) => a * 10 + b);
		}

		private static IEnumerable<int> GetPermutation (int [] digits, int index)
		{
			var sorted = digits.OrderBy (d => d).ToList ();
			if (digits.Length == 1)
			{
				yield return sorted [index];
				yield break;
			}

			var permutations = (digits.Length - 1).GetFactorial ();
			var localIndex = index / permutations;
			yield return sorted [localIndex];
			sorted.RemoveAt (localIndex);

			foreach (var sub in GetPermutation (
				sorted.ToArray (),
				index % permutations))
				yield return sub;
		}
	}
}

