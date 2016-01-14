using System;

namespace eulerproject
{
	[AttributeUsage (AttributeTargets.Class)]
	public class ProblemAttribute : Attribute
	{
		// Properties

		public string Name { get; private set; }
		public int Number { get; private set; }
		public long Result { get; private set; }



		// Constructor

		public ProblemAttribute (int number, string name, long result)
		{
			this.Number = number;
			this.Name = name;
			this.Result = result;
		}
	}
}

