using System.Numerics;
using System.Linq;

namespace eulerproject
{
	[Problem (16, "Power digit sum", 1366)]
	public class Problem16 : IProblem
	{
		public long Run ()
		{
			return BigInteger.Pow (new BigInteger (2), 1000)
				.ToString ()
				.Select (c => int.Parse (c.ToString ()))
				.Sum ();
		}
	}
}

