using System;
using System.Collections.Generic;

namespace eulerproject
{
	public static class Naturals
	{
		public static IEnumerable <int> Get ()
		{
			return Get (1);
		}

		public static IEnumerable <int> Get (int n)
		{
			while (true)
			{
				yield return n;
				n++;
			}
		}
	}
}

