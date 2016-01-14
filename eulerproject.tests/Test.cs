using NUnit.Framework;
using System;

namespace eulerproject.tests
{
	[TestFixture]
	public class Test
	{
		[Test]
		public void TestProblem1 ()
		{
			Assert.AreEqual (new Problem1 ().Run (), 234168);
		}
	}
}

