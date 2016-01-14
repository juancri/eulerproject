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

		[Test]
		public void TestProblem2 ()
		{
			Assert.AreEqual (new Problem2 ().Run (), 4613732);
		}

		[Test]
		public void TestProblem3 ()
		{
			Assert.AreEqual (new Problem3 ().Run (), 6857);
		}

		[Test]
		public void TestProblem4 ()
		{
			Assert.AreEqual (new Problem4 ().Run (), 906609);
		}
	}
}

