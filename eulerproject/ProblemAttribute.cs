using System;

namespace eulerproject
{
	[AttributeUsage (AttributeTargets.Class)]
	public class ProblemAttribute : Attribute
	{
		// Properties

		public string Name { get; private set; }
		public int Number { get; private set; }



		// Constructor

		public ProblemAttribute (int number, string name)
		{
			this.Number = number;
			this.Name = name;
		}
	}
}

