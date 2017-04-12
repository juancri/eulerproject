using System.Linq;

namespace eulerproject
{
	[Problem (34, "Digit factorials", 40730)]
	public class Problem34 : IProblem
	{
		public long Run ()
		{
			return Enumerable.Range (3, 100000)
				.Where (n => n == n.GetDigits ()
					.Select (d => d.GetFactorial ()).Sum ())
				.Sum ();
		}
	}
}

