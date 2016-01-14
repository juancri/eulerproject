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
				let problemAttribute = (ProblemAttribute)t.GetCustomAttribute (typeof(ProblemAttribute))
				select new ProblemDefinition
				{
					Name = problemAttribute.Name,
					Number = problemAttribute.Number,
					Problem = (IProblem)t.GetConstructor (new Type [0]).Invoke (new object [0])
				};
		}
	}
}

