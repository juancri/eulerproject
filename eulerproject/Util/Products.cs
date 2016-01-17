using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	public static class Products
	{
		public static IEnumerable <int> Get (int min, int max)
		{
			return
				from x1 in Enumerable.Range (min, max - min + 1)
				from x2 in Enumerable.Range (min, x1 - min + 1)
				select x1 * x2;
		}
	}
}

