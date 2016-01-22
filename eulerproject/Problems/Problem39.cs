using System;
using System.Linq;

namespace eulerproject
{
	[Slow]
	[Problem (39, "Integer right triangles", 840)]
	public class Problem39 : IProblem
	{
		public long Run ()
		{
			return Enumerable.Range (1, 1000)
				.AsParallel ()
				.OrderByDescending (n => GetRightAngleTriangles (n))
				.First ();
		}

		private static long GetRightAngleTriangles (int perimeter)
		{
			var result =
				from a in Enumerable.Range (1, perimeter / 3)
				from b in Enumerable.Range (a, perimeter - a)
				let c = perimeter - (a + b)
				where Math.Pow (a, 2) + Math.Pow (b, 2) == Math.Pow (c, 2)
				select 1;

			return result.Count ();
		}
	}
}

