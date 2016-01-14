using System;

namespace eulerproject
{
	[AttributeUsage (AttributeTargets.Class)]
	public class SlowAttribute : Attribute
	{
		public SlowAttribute ()
		{
		}
	}
}

