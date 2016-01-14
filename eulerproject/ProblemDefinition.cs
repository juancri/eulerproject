using System;

namespace eulerproject
{
	public class ProblemDefinition
	{
		// Properties

		public int Number { get; set; }
		public string Name { get; set; }
		public IProblem Problem { get; set; }



		// Constructor

		public ProblemDefinition ()
		{
		}
	}
}

