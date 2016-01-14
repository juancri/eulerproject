using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace eulerproject
{
	public static class ProblemReader
	{
		// Public methods

		public static IEnumerable <ProblemDefinition> GetProblems ()
		{
			return
				from t in Assembly.GetExecutingAssembly ().DefinedTypes
				where t.ImplementedInterfaces.Any (i => i == typeof(IProblem))
				select new ProblemDefinition
				{
					Attribute = (ProblemAttribute)t.GetCustomAttribute (typeof(ProblemAttribute)),
					Problem = (IProblem)t.GetConstructor (new Type [0]).Invoke (new object [0]),
					IsSlow = t.GetCustomAttribute (typeof(SlowAttribute)) != null
				};
		}
	}
}

