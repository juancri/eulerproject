using System;
using System.Collections.Generic;

namespace eulerproject
{
	public static class CollatzSequence
	{
		public static IEnumerable <long> Get (long start)
		{
			while (true)
			{
				yield return start;
				if (start == 1)
					yield break;
				
				if ((start & 1) == 0)
					start = start / 2;
				else
					start = start * 3 + 1;
			}
		}
	}
}

