using System;
using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (14, "Longest Collatz sequence", 837799)]
	public class Problem14 : IProblem
	{
		public long Run ()
		{
			var numbers = new Dictionary <long, int> ();
			foreach (var x in Enumerable.Range (1, 999999))
			{
				var local = new List <long> ();
				var distance = 0;
				foreach (var y in CollatzSequence.Get (x))
				{
					if (numbers.ContainsKey (y))
					{
						distance = numbers [y];
						break;
					}
					else
						local.Add (y);
				}

				local.Reverse ();
				for (var i = 0; i < local.Count; i++)
					numbers.Add (local [i], i + distance + 1);
			}
			return
				numbers
					.OrderByDescending (n => n.Value)
					.First ()
					.Key;
		}
	}
}

