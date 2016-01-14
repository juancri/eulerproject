using System;
using System.Linq;

namespace eulerproject
{
	class MainClass
	{
		public static void Main ()
		{
			var problems = ProblemReader.GetProblems ().ToList ();
			foreach (var p in problems)
				Console.WriteLine ("{0:00000}: {1}", p.Number, p.Name);
			Console.WriteLine ("Type problem number to execute:");
			var number = Console.ReadLine ();
			Console.WriteLine (problems
				.First (p => p.Number == int.Parse (number))
				.Problem.Run ());
		}
	}
}
