using System;
using System.Diagnostics;
using System.Linq;

namespace eulerproject
{
	class MainClass
	{
		public static void Main ()
		{
			var problems = ProblemReader.GetProblems ().ToList ();
			foreach (var p in problems)
			{
				Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write (" Problem {0:00000} ", 
					p.Attribute.Number);

				Console.BackgroundColor = ConsoleColor.Blue;
				Console.Write (" {0, -35} ", 
					p.Attribute.Name);

				if (p.IsSlow)
				{
					Console.BackgroundColor = ConsoleColor.DarkGray;
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine (" [SLOW!] ");
					Console.ForegroundColor = ConsoleColor.White;
				}
				else
					Console.WriteLine ("         ");
			}
			Console.ResetColor ();
			Console.WriteLine ("Type problem number to execute or ENTER to run all:");
			var line = Console.ReadLine ();
			if (line.Length == 0) {
				foreach (var p in problems)
					Run (p);
			} else {
				var number = int.Parse (line);
				var problem = problems
					.First (p => p.Attribute.Number == number);
				Run (problem);
			}			
		}

		private static void Run (ProblemDefinition p)
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write (" Problem {0:00000} ", 
				p.Attribute.Number);

			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Write (" {0, -35} ", 
				p.Attribute.Name);

			if (p.IsSlow)
			{
				Console.BackgroundColor = ConsoleColor.DarkGray;
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write (" [SLOW!] ");
				Console.ForegroundColor = ConsoleColor.White;
			}
			else
				Console.Write ("         ");

			var sw = new Stopwatch();
			sw.Start ();
			var result = p.Problem.Run ();
			sw.Stop ();
			if (result == p.Attribute.Result)
			{
				Console.BackgroundColor = ConsoleColor.Green;
				Console.Write (" OK ");
			}
			else
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.Write (" ERROR ");
			}

			if (sw.Elapsed > TimeSpan.FromSeconds (1))
				Console.BackgroundColor = ConsoleColor.DarkRed;
			else
				Console.BackgroundColor = ConsoleColor.DarkYellow;
			Console.Write (" ({0}ms) ", sw.ElapsedMilliseconds);

			Console.ResetColor ();
			Console.WriteLine (" Expected: {0} Got: {1}",
				p.Attribute.Result, result);
		}
	}
}
