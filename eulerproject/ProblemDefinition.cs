using System;

namespace eulerproject
{
	public class ProblemDefinition
	{
		// Properties

		public ProblemAttribute Attribute { get; set; }
		public bool IsSlow { get; set; }
		public IProblem Problem { get; set; }



		// Constructor

		public ProblemDefinition ()
		{
		}
	}
}

