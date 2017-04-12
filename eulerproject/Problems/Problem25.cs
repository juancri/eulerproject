using System.Linq;

namespace eulerproject
{
	[Problem (25, "1000-digit Fibonacci number", 4782)]
	public class Problem25 : IProblem
	{
		public long Run ()
		{
			return BigFibonacci.Get ()
				.Select ((x, i) => new { number = x, index = i })
				.Where (x => x.number.ToString ().Length == 1000)
				.Select (x => x.index + 2)
				.First ();
		}
	}
}

