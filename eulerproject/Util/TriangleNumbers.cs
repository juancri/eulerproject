using System;
using System.Collections.Generic;

namespace eulerproject
{
	public static class TriangleNumbers
	{
		public static IEnumerable <int> Get ()
		{
			int current = 0;
			int n = 0;
			while (true)
			{
				n++;
				yield return (current += n);
			}
		}
	}
}

