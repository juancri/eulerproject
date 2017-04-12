using System.Linq;

namespace eulerproject
{
	[Problem (9, "Special Pythagorean triplet", 31875000)]
	public class Problem9 : IProblem
	{
		public long Run ()
		{
			return PythagoreanTriplet.GetAll ()
				.Where (pt => pt.A + pt.B + pt.C == 1000)
				.Select (pt => pt.A * pt.B * pt.C)
				.First ();
		}
	}
}

