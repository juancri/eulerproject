using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	public static class LatticePaths
	{
		public static long Get (int size)
		{
			return Get (
				size, size,
				new Dictionary <Tuple <int, int>, long> ());
		}

		private static long Get (int sizeA, int sizeB, Dictionary <Tuple <int, int>, long> cache)
		{
			// Normalize
			var normalizedSizeA = Math.Min (sizeA, sizeB);
			var normalizedSizeB = Math.Max (sizeA, sizeB);
			var tuple = new Tuple <int, int> (normalizedSizeA, normalizedSizeB);

			// Check cache
			if (cache.ContainsKey (tuple))
				return cache [tuple];

			// Calculate
			var possible = sizeA <= 1 || sizeB <= 1 ? 
				sizeA + sizeB :
				Get (sizeA, sizeB - 1, cache) +
				Get (sizeA - 1, sizeB, cache);

			// Save
			cache.Add (tuple, possible);

			// Done
			return possible;
		}
	}
}

