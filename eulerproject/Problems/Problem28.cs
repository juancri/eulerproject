using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (28, "Number spiral diagonals", 669171001)]
	public class Problem28 : IProblem
	{
		public long Run ()
		{
			return GetDiagonals (1001)
				.Sum ();
		}

		private static IEnumerable<int> GetDiagonals (int size)
		{
			yield return 1;
			var max = size * size;
			var current = 1;
			var step = 2;
			while (current < max)
			{
				foreach (var n in Enumerable.Range (1, 4))
					yield return current + step * n;

				current += step * 4;
				step += 2;
			}
		}
	}
}

