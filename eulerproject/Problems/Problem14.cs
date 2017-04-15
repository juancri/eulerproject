using System.Collections.Generic;
using System.Linq;

namespace eulerproject
{
	[Problem (14, "Longest Collatz sequence", 837799)]
	public class Problem14 : IProblem
	{
		public long Run ()
		{
			var numbers = new int[1000000];
			var maxNumber = 1;
			foreach (var x in Enumerable.Range (1, 999999))
			{
				var local = new List <long> ();
				var distance = 0;
				foreach (var y in CollatzSequence.Get (x))
				{
					if (y < 1000000 && numbers [y - 1] > 0)
					{
						distance = numbers [y - 1];
						break;
					}
					else
						local.Add (y);
				}

				for (var i = 0; i < local.Count; i++)
					if (local[local.Count - 1 - i] < 1000000)
						numbers[local[local.Count - 1 - i] - 1] = i + distance + 1;

				if (numbers [maxNumber - 1] < distance + local.Count)
					maxNumber = (int) local[0];
			}

			return maxNumber;
		}
	}
}

