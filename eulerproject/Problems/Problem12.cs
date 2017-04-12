using System.Linq;

namespace eulerproject
{
	[Problem (12, "Highly divisible triangular number", 76576500)]
	public class Problem12 : IProblem
	{
		public long Run ()
		{
			return TriangleNumbers.Get ()
				.Where (x => x.GetFactors ().Count () > 500)
				.First ();
		}
	}
}

