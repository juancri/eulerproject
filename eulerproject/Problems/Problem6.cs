﻿using System;
using System.Linq;

namespace eulerproject
{
	[Problem (6, "Sum square difference", 25164150)]
	public class Problem6 : IProblem
	{
		public long Run ()
		{
			var sumOfSquares = Enumerable.Range (1, 100)
				.Select (x => Math.Pow (x, 2))
				.Sum ();
			var squareOfSum = Math.Pow (
				Enumerable.Range (1, 100).Sum (),
				2);
			return (int) Math.Abs (sumOfSquares - squareOfSum);
		}
	}
}

