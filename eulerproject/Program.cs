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
				Console.WriteLine ("{0}: {1}", p.Number, p.Name);
			Console.WriteLine ("Type problem number to execute:");
			Console.WriteLine (problems
				.First (p => p.Number == int.Parse (Console.ReadLine ()))
				.Problem.Run ());
		}
	}
}
